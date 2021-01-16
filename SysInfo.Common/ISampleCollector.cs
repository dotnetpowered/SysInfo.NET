//
// SysInfo.ISampleCollector
//
// Authors:
//   Brian Ritchie (brian.rtichie@gmail.com)
//
// Copyright (C) Brian Ritchie
//
using System;

namespace SysInfo
{
	public interface ISampleCollector
	{
		Sample CollectStaticSample();
		Sample CollectDynamicSample();
	}
}
