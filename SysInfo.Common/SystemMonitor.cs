//
// SysInfo.SystemMonitor
//
// Authors:
//   Brian Ritchie (brianlritchie@hotmail.com)
//
// Copyright (C) Brian Ritchie, 2005
//
using System;
using System.Collections;
using System.Xml;
using System.IO;
using System.Threading;

namespace SysInfo
{
	internal class SystemMonitor
	{
		private ISampleCollector Collector;
		private Queue Samples;
		private Thread MonitorThread;
		private Sample StaticSample;
		private int MaxSamples;

		public SystemMonitor(ISampleCollector collector, int MaxSamples)
		{
			this.MaxSamples=MaxSamples;
			this.Collector=collector;
			StaticSample=collector.CollectStaticSample();
			Samples=new Queue();
			MonitorThread=new Thread(new ThreadStart(MonitorThreadMain));
			MonitorThread.IsBackground=true;
			MonitorThread.Start();
		}

		public Sample GetStaticSample()
		{
			return StaticSample;
		}

		public Sample[] GetDynamicSamples()
		{
			Mutex mutex=new Mutex(false,"monitorthread");
			mutex.WaitOne();
			ArrayList SampleList=new ArrayList(Samples);
			Sample[] samples=(Sample[]) SampleList.ToArray(typeof(Sample));
			mutex.ReleaseMutex();
			return samples;
		}

		private void AddSample(Sample sample)
		{
			Mutex mutex=new Mutex(false,"monitorthread");
			if (mutex.WaitOne())
			{
				Samples.Enqueue(sample);
				if (Samples.Count>MaxSamples)
					Samples.Dequeue();
			}
			mutex.ReleaseMutex();
		}
 
		public void MonitorThreadMain()
		{
			//while (Thread.CurrentThread.IsAlive) -- causes intermittent errors on Mono
			while (true)
			{
				Sample sample=Collector.CollectDynamicSample();
				AddSample(sample);
				Thread.Sleep(1000);
			} 
		}
	}
}
