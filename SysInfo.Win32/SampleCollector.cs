//
// SysInfo.Win32.SampleCollector
//
// Authors:
//   Brian Ritchie (brianlritchie@hotmail.com)
//
// Copyright (C) Brian Ritchie, 2005
//
using System;
using SysInfo.Win32;

namespace SysInfo.Win32
{
	/// <summary>
	/// Implements the ISampleCollector for the Win32 Platform.
	/// </summary>
	public class SampleCollector : ISampleCollector
	{
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
			ROOT.CIMV2.OperatingSystem.OperatingSystemCollection OpSysList=
				ROOT.CIMV2.OperatingSystem.GetInstances();
			foreach (ROOT.CIMV2.OperatingSystem OpSys in OpSysList)
			{
				sample.AddEntry(category,"OSDescription",OpSys.Caption);
				sample.AddEntry(category,"LastBootTime",OpSys.LastBootUpTime);
			}
			
			ROOT.CIMV2.ComputerSystem.ComputerSystemCollection CompSysList=
				ROOT.CIMV2.ComputerSystem.GetInstances();
			foreach (ROOT.CIMV2.ComputerSystem CompSys in CompSysList)
			{
				sample.AddEntry(category,"Manufacturer",CompSys.Manufacturer);
				sample.AddEntry(category,"Model",CompSys.Model.Trim());
				sample.AddEntry(category,"TotalPhysicalMemory",CompSys.TotalPhysicalMemory);
			}

			sample.AddEntry(category,"ComputerName",System.Environment.MachineName);
			sample.AddEntry(category,"OSVersion",System.Environment.OSVersion);
			sample.AddEntry(category,"FrameworkVersion",System.Environment.Version);

			ROOT.CIMV2.Processor.ProcessorCollection ProcessorList=
				ROOT.CIMV2.Processor.GetInstances();
			foreach (ROOT.CIMV2.Processor Processor in ProcessorList)
			{
				sample.AddEntry(Processor.DeviceID,"Processor",Processor.Name.Trim());
				sample.AddEntry(Processor.DeviceID,"ClockSpeed",Processor.MaxClockSpeed);
				sample.AddEntry(Processor.DeviceID,"Architecture",Processor.Architecture);
			}

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
			return sample;			
		}

		/// <summary>
		/// Collects a set of measurements that change often.
		/// </summary>
		/// <returns></returns>
		public Sample CollectDynamicSample()
		{
			Sample sample=new Sample(SampleKind.Dynamic);

			string category="System";
			ROOT.CIMV2.OperatingSystem.OperatingSystemCollection OpSysList=
				ROOT.CIMV2.OperatingSystem.GetInstances();
			foreach (ROOT.CIMV2.OperatingSystem OpSys in OpSysList)
			{
				sample.AddEntry(category,"FreePhysicalMemory",OpSys.FreePhysicalMemory);
			}
			sample.AddEntry(category,"ProcessCount",System.Diagnostics.Process.GetProcesses().Length);

			ROOT.CIMV2.Processor.ProcessorCollection ProcessorList=
				ROOT.CIMV2.Processor.GetInstances();
			foreach (ROOT.CIMV2.Processor Processor in ProcessorList)
			{
				sample.AddEntry(Processor.DeviceID,"LoadPercentage",Processor.LoadPercentage);
			}

			return sample;
		}

		#endregion
	}
}
