//
// SysInfo.ISampleCollector
//
// Authors:
//   Brian Ritchie (brianlritchie@hotmail.com)
//
// Copyright (C) Brian Ritchie, 2005
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
