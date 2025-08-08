using System.Diagnostics;
using System.Windows.Threading;

namespace WpfStopwatchGemini
{
    public class Model
    {
        private readonly Stopwatch _stopwatch = new Stopwatch();
        private readonly DispatcherTimer _timer = new DispatcherTimer();

        // An event that notifies subscribers (the Presenter) of the new elapsed time
        public event Action<TimeSpan> TimeUpdated;

        public Model()
        {
            // Set the timer to tick every 100 milliseconds for a smooth update
            _timer.Interval = TimeSpan.FromMilliseconds(100);
            _timer.Tick += (sender, e) => TimeUpdated?.Invoke(_stopwatch.Elapsed);
        }

        public void Start()
        {
            _stopwatch.Start();
            _timer.Start();
        }

        public void Stop()
        {
            _stopwatch.Stop();
            _timer.Stop();
        }

        public void Reset()
        {
            _stopwatch.Reset();
            // Manually update the time to 00:00 after resetting
            TimeUpdated?.Invoke(TimeSpan.Zero);
        }
    }
}
