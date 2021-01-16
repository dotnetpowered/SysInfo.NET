//
// SysInfo.ServerEnvironment
//
// Authors:
//   Brian Ritchie (brian.rtichie@gmail.com)
//
// Copyright (C) Brian Ritchie
//
using System;

namespace SysInfo
{
	public class ServerEnvironment
	{

		public ServerEnvironment()
		{
		}

		public long TickCount
		{
			get
			{
				return Environment.TickCount;
			}
		}

		public PlatformID Platform
		{
			get
			{
				return Environment.OSVersion.Platform;
			}
		}

		public string MachineName
		{
			get
			{
				return Environment.MachineName;
			}
		}

		public Version OSVersion
		{
			get
			{
				return Environment.OSVersion.Version;
			}
		}

		public Version CLRVersion
		{
			get
			{
				return Environment.Version;
			}
		}
	}
}
