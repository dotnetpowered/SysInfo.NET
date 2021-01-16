//
// SysInfo.Sample
//
// Authors:
//   Brian Ritchie (brian.rtichie@gmail.com)
//
// Copyright (C) Brian Ritchie
//
using System;
using System.Collections.Generic;

namespace SysInfo
{
	[Serializable]
	public class Sample
    {
        private List<SampleEntry> EntryList = new();

		public Sample()
		{
			DateCollected = DateTime.Now;
		}

		public Sample(SampleKind kind)
		{
			DateCollected=DateTime.Now;
			Kind=kind;
		}

		public SampleEntry[] Items
		{
			get
			{
				return EntryList.ToArray();
			}
			set
			{
				EntryList=new (value);
			}
		}

		public void AddEntry(string Category, string Name, object Value)
		{
			EntryList.Add(new SampleEntry(Category,Name,Value.ToString()));
		}

		public DateTime DateCollected { get; set; }
		public SampleKind Kind { get; set; }
	}
}
