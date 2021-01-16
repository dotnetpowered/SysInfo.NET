//
// SysInfo.Sample
//
// Authors:
//   Brian Ritchie (brianlritchie@hotmail.com)
//
// Copyright (C) Brian Ritchie, 2005
//
using System;
using System.Collections;

namespace SysInfo
{
	[Serializable]
	public class Sample
	{
		private ArrayList EntryList;
		private DateTime _DateCollected;
		private SampleKind _Kind;

		public Sample()
		{
		}

		public Sample(SampleKind kind)
		{
			DateCollected=DateTime.Now;
			Kind=kind;
			EntryList=new ArrayList();
		}

		public SampleEntry[] Items
		{
			get
			{
				return (SampleEntry[]) EntryList.ToArray(typeof(SampleEntry));
			}
			set
			{
				EntryList=new ArrayList(value);
			}
		}

		public void AddEntry(string Category, string Name, object Value)
		{
			EntryList.Add(new SampleEntry(Category,Name,Value.ToString()));
		}

		public DateTime DateCollected
		{
			get
			{
				return _DateCollected;
			}
			set
			{
				_DateCollected=value;
			}
		}

		public SampleKind Kind
		{
			get
			{
				return _Kind;
			}
			set
			{
				_Kind=value;
			}
		}

	}
}
