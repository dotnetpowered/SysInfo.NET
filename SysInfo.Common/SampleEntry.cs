//
// SysInfo.SampleEntry
//
// Authors:
//   Brian Ritchie (brianlritchie@hotmail.com)
//
// Copyright (C) Brian Ritchie, 2005
//
using System;

namespace SysInfo
{
	[Serializable]
	public class SampleEntry
	{
		private string _Category;
		private string _Name;
		private string _Value;		

		public SampleEntry()
		{
		}

		public string Category
		{
			get
			{
				return _Category;
			}
			set
			{
				_Category=value;
			}
		}

		public string Name
		{
			get
			{
				return _Name;
			}
			set
			{
				_Name=value;
			}
		}

		public string Value
		{
			get
			{
				return _Value;
			}
			set
			{
				_Value=value;
			}
		}

		public SampleEntry(string Category, string Name, string Value)
		{
			this.Category=Category;
			this.Name=Name;
			this.Value=Value;
		}
	}
}
