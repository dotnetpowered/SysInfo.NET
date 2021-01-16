//
// SysInfo.SystemMonitor
//
// Authors:
//   Brian Ritchie (brian.rtichie@gmail.com)
//
// Copyright (C) Brian Ritchie
//
using System.Collections.Concurrent;
using System.Threading;

namespace SysInfo
{
	internal class SystemMonitor
	{
		private ISampleCollector Collector;
		private ConcurrentQueue<Sample> Samples;
		private Thread MonitorThread;
		private Sample StaticSample;
		private int MaxSamples;

		public SystemMonitor(ISampleCollector collector, int MaxSamples)
		{
			this.MaxSamples=MaxSamples;
			this.Collector=collector;
			StaticSample=collector.CollectStaticSample();
			Samples=new ();
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
			return Samples.ToArray();
		}

		private void AddSample(Sample sample)
		{
			Samples.Enqueue(sample);
			if (Samples.Count>MaxSamples)
				Samples.TryDequeue(out _);
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
