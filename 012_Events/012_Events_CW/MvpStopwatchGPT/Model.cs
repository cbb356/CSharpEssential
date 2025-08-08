using System;
using System.Diagnostics;
using System.Windows.Threading;

namespace MvpStopwatchGPT
{
    public class Model
    {
        private readonly Stopwatch stopwatch;
        private readonly DispatcherTimer timer;

        public event Action<TimeSpan> TimeUpdated;

        public Model()
        {
            stopwatch = new Stopwatch();
            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(100)
            };
            timer.Tick += (s, e) => TimeUpdated?.Invoke(stopwatch.Elapsed);
        }

        public void Start()
        {
            stopwatch.Start();
            timer.Start();
        }

        public void Stop()
        {
            stopwatch.Stop();
            timer.Stop();
        }

        public void Reset()
        {
            stopwatch.Reset();
            TimeUpdated?.Invoke(TimeSpan.Zero);
        }
    }
}
