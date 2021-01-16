//
// SysInfo.SampleEntry
//
// Authors:
//   Brian Ritchie (brian.rtichie@gmail.com)
//
// Copyright (C) Brian Ritchie
//
using System;

namespace SysInfo
{
	[Serializable]
	public class SampleEntry
	{
		public SampleEntry()
		{
		}

		public string Category { get; set; }
		public string Name { get; set; }
		public string Value { get; set; }

		public SampleEntry(string Category, string Name, string Value)
		{
			this.Category=Category;
			this.Name=Name;
			this.Value=Value;
		}
	}
}
