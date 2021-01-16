//
// SysInfo.Linux.SampleCollector
//
// Authors:
//   Brian Ritchie (brianlritchie@hotmail.com)
//   Anthony Whalley (tont@o2.ie)	
//
// Copyright (C) Brian Ritchie, 2005

//Thanks to
//	Al Stone 		hp
//      Christopher Neufeld 	linuxcare
//	David Kennedy       	linuxcare
//      Christopher Neufeld 	linuxcare
//      Al Stone        	hp
//      David Eger      	ibm 
//
//	For the Pegasus Providers 

using System;
using System.IO ;

namespace SysInfo.Linux
{
	/// <summary>
	/// Implements the ISampleCollector for the Linux Platform.
	/// </summary>
	public class SampleCollector : ISampleCollector
	{
		float usrTime = 0 ;
		float niceTime = 0 ;
		float sysTime = 0 ;
		float idleTime = 0 ;
		float ttlProcTime = 0 ;
		float ttlUsedProcTime = 0 ;
		float ttlProcTimePercent = 0 ;
		float ttlUsrTimePercent = 0 ;
		public SampleCollector()
		{}

		#region ISampleCollector Members

		/// <summary>
		/// Collects a set of static information & measurements 
		/// </summary>
		/// <returns>Sample containing collected measurements</returns>
		public Sample CollectStaticSample()
		{
			Sample sample=new Sample(SampleKind.Static);
			string category="System";
			string nextLine = "" ;
			sample.AddEntry(category,"OSDescription",SampleTools.GetOsDescription());
			sample.AddEntry(category,"LastBootTime",SampleTools.LastBootUpTime());
			
			/*
				sample.AddEntry(category,"Manufacturer",CompSys.Manufacturer);
				sample.AddEntry(category,"Model",CompSys.Model.Trim());
			*/
			try
			{
				FileStream fs=new FileStream("/proc/meminfo", FileMode.Open, FileAccess.Read, FileShare.Read);
				StreamReader sr =new StreamReader(fs);
				while (!nextLine.StartsWith("MemTotal:"))
				{
					nextLine = sr.ReadLine() ;
				}
				string[] nextLineParts = nextLine.Split(' ') ;
				for(int i = 1; i < nextLineParts.Length; i++)
				{
					if(nextLineParts[i].Length > 0)
					{
						sample.AddEntry(category,"TotalPhysicalMemory",nextLineParts[i]);
						break ;						
					} 
				} 
				sr.Close() ;
				fs.Close() ;
			}	
			catch(Exception exp)
			{
				throw exp ;
			}
			sample.AddEntry(category,"ComputerName",System.Environment.MachineName);
			sample.AddEntry(category,"OSVersion",System.Environment.OSVersion);
			sample.AddEntry(category,"FrameworkVersion",System.Environment.Version);


			try
			{
				int cpuNo = 0;
				string cpuName = "" ;
				//string cpuClockSpeed = "" ;
				//string cpuArchitecture = "" ;

				FileStream fs=new FileStream("/proc/cpuinfo", FileMode.Open, FileAccess.Read, FileShare.Read);
				StreamReader sr =new StreamReader(fs);
				
				while (sr.Peek() != -1)
				{
					nextLine = sr.ReadLine() ;
						
					string[] nextLineParts = nextLine.Split(' ') ;
				
					if(nextLineParts.Length > 1)
					{
						if(nextLineParts[1].StartsWith("name"))
						{
							for(int i = 2; i < nextLineParts.Length; i++)
							{
								cpuName += nextLineParts[i] + " ";
								//sample.AddEntry("cpu" + cpuNo,"ClockSpeed",cpuClockSpeed);
								//sample.AddEntry("cpu" + cpuNo,"Architecture",cpuArchitecture); 
							}
							string deviceId = "cpu" + cpuNo ;
							cpuNo++ ;
							sample.AddEntry(deviceId,"Processor",cpuName.Trim());
						}
					}
				} 
				sr.Close() ;
				fs.Close() ;
			}	
			catch(Exception exp)
			{
				throw exp ;
			}

			if (Directory.Exists("/proc/ide"))
			{
				string [] subdirEntries = Directory.GetDirectories("/proc/ide");
				int diskId = 0 ;
			
				foreach(string subdir in subdirEntries)
				{
				
					if(subdir.StartsWith("/proc/ide/hd"))
					{
						FileStream fsMedia=new FileStream(subdir +"/media", FileMode.Open, FileAccess.Read, FileShare.Read);
						StreamReader srMedia =new StreamReader(fsMedia);
						string diskType = srMedia.ReadLine() ;
						fsMedia.Close() ;
						srMedia.Close() ;
						if(diskType.StartsWith("disk"))
						{
							string DiskCategory="Disk."+diskId;
							string modelLoc = subdir +"/model" ;
							FileStream fsModel=new FileStream(modelLoc, FileMode.Open, FileAccess.Read, FileShare.Read);
							StreamReader srModel =new StreamReader(fsModel);
							string diskName = srModel.ReadLine() ;
							sample.AddEntry(DiskCategory,"Type",diskName);
							fsModel.Close() ;
							srModel.Close() ;
						
							string diskLoc = subdir + "/capacity" ;
							FileStream fsDisk = new FileStream(diskLoc, FileMode.Open, FileAccess.Read, FileShare.Read) ;
							StreamReader srDisk = new StreamReader(fsDisk) ;
							long diskSize = long.Parse(srDisk.ReadLine()) ;
							fsDisk.Close() ;
							srDisk.Close() ;
							long diskgb = diskSize / 2097152 ; //2097152 is Gb
							string sDiskSize = diskgb.ToString() + " Gb" ; 
							sample.AddEntry(DiskCategory,"Size",sDiskSize);
							diskId++ ;
						}	
					}
				}
			}
			// Do not iterate through reparse points 2097152
			//}

			/*
			ROOT.CIMV2.LogicalDisk.LogicalDiskCollection DiskList=
				ROOT.CIMV2.LogicalDisk.GetInstances();
			foreach (ROOT.CIMV2.LogicalDisk Disk in DiskList)
			{
				if (Disk.Description=="Local Fixed Disk")
				{
					string DiskCategory="Disk."+Disk.DeviceID;
					sample.AddEntry(DiskCategory,"FileSystem",Disk.FileSystem);
					sample.AddEntry(DiskCategory,"Type",Disk.Description);
					sample.AddEntry(DiskCategory,"Size",Disk.Size);
				}
			}
			*/
			return sample;			
		}

		/// <summary>
		/// Collects a set of measurements that change often.
		/// The free physical memory returns the stats as 
		/// KB this does not graph well should it be a percentage
		//  of memory. 
		///</summary>
		/// <returns></returns>
		public Sample CollectDynamicSample()
		{
			Sample sample=new Sample(SampleKind.Dynamic);
			string category="System";
			string nextLine ;
				
			try
			{
				FileStream fs=new FileStream("/proc/meminfo", FileMode.Open, FileAccess.Read, FileShare.Read);
				StreamReader sr =new StreamReader(fs);
				nextLine = sr.ReadLine() ;
				while (!nextLine.StartsWith("MemFree:"))
				{
					nextLine = sr.ReadLine() ;
				}
				string[] nextLineParts = nextLine.Split(' ') ;
				for(int i = 1; i < nextLineParts.Length; i++)
				{
					if(nextLineParts[i].Length > 0)
					{
						sample.AddEntry(category,"FreePhysicalMemory",nextLineParts[i]);
						break ;						
					} 
				} 
				sr.Close() ;
				fs.Close() ;
			}	
			catch(Exception exp)
			{
				throw exp ;
			}
			
			sample.AddEntry(category,"ProcessCount",System.Diagnostics.Process.GetProcesses().Length);
			try
			{
				FileStream fs=new FileStream("/proc/stat", FileMode.Open, FileAccess.Read, FileShare.Read);

				StreamReader sr =new StreamReader(fs);
				nextLine = sr.ReadLine() ;
			
			
				while (nextLine.StartsWith("cpu"))
				{
			
					nextLine = sr.ReadLine() ;
					
					if(nextLine.StartsWith("cpu"))
					{
						string[] readings = nextLine.Split(' ') ;
						usrTime = float.Parse(readings[1]) ;
						niceTime = float.Parse(readings[2]) ;
						sysTime = float.Parse(readings[3]) ;
						idleTime = float.Parse(readings[4]) ;

						ttlUsedProcTime = usrTime + niceTime + sysTime ;
						ttlProcTime = ttlUsedProcTime + idleTime ;
						ttlUsrTimePercent = (usrTime/ttlProcTime) * 100 ;	
			
						ttlProcTimePercent = (ttlUsedProcTime/ttlProcTime) * 100 ;
						sample.AddEntry		
							(readings[0].ToUpper(),"LoadPercentage",ttlProcTimePercent);
						
					}
				}
				sr.Close() ;
				fs.Close() ;
			}
			catch(Exception ex)
			{
				throw ex ;
			}
			return sample;
		}
		
		#endregion
	}
}


