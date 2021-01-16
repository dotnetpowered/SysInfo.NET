//
// SysInfo.Linux.SampleTools
//
// Authors:
//   Anthony Whalley (tont@o2.ie)	
//
// Copyright (C) Brian Ritchie, 2005

using System;
using System.IO ;

namespace SysInfo.Linux
{
	public class SampleTools
	{
		public static string GetOsDescription()
		{
			//string osDesc =  GetFirstLine("/proc/version") ;
			string[] osPart = GetFirstLine("/proc/version").Split('#') ;
			return osPart[0];
		}
	
		public static string GetTimeUp()
		{
			string[] tmpUpTime = GetFirstLine("/proc/uptime").Split(' ') ;
			long mins = 60;
			long hour = mins * 60;
			long day = hour * 24;
			long time = long.Parse(tmpUpTime.ToString()) ;
			//long tmpMin = time % mins ;
			return "Days : " + time % day + " Hours : " + time % hour + "Mins : " + time % mins ;	
			/* Produce output. */
			//printf ("%s: %ld days, %ld:%02ld:%02ld\n", label, time / day, 
			//   (time % day) / hour, (time % hour) / minute, time % minute);

		
		}
		/* Conversion constants. */
 
		private static string GetFirstLine(string procLoc)
		{
			FileInfo fi = new FileInfo(procLoc) ;
			StreamReader sr = fi.OpenText() ;
			string nextLine = sr.ReadLine() ;
			sr.Close() ;
			return nextLine ;
		}	

		public static string LastBootUpTime()
		{
			string uptimeString = "" ;
			try
			{
				FileStream fs=new FileStream("/proc/uptime", FileMode.Open, FileAccess.Read, FileShare.Read);
				StreamReader sr =new StreamReader(fs);
				uptimeString = sr.ReadLine().Split('.')[0] ;
			
				int upSeconds = int.Parse(uptimeString) ;
				int secs = upSeconds % 60;
				int mins = upSeconds / 60 % 60;
				int hours = upSeconds / 3600 % 24;
				int days = upSeconds / 86400;
				if (days > 0) 
				{
					uptimeString += days;
					uptimeString += ((days == 1) ? " day" : " days") + ", ";
				}
				if (hours > 0) 
				{
					uptimeString += hours;
					uptimeString += ((hours == 1) ? " hour" : " hours") + ", ";
				}
				if (mins > 0) 
				{
					uptimeString += mins;
					uptimeString += ((mins == 1) ? " minute" : " minutes") + ", ";
				}
				uptimeString += secs;
				uptimeString += ((secs == 1) ? " second" : " seconds");
				DateTime dt = DateTime.Now ;
				TimeSpan ts = new TimeSpan(days, hours, mins, secs, 0) ;
				DateTime dtBoot = dt.Subtract(ts) ;
				uptimeString = dtBoot.ToString() ; 
				sr.Close() ;
				fs.Close() ;


			}
			catch(Exception ex)
			{
				throw ex ;
			}
			return uptimeString ;
		} 
	}
}


