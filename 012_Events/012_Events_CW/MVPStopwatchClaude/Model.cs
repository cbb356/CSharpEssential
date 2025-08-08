using System;
using System.Diagnostics;

namespace MVPStopwatchClaude
{
    /// <summary>
    /// Model class that encapsulates the stopwatch logic and state
    /// </summary>
    public class Model
    {
        private readonly Stopwatch _stopwatch;

        public Model()
        {
            _stopwatch = new Stopwatch();
        }

        /// <summary>
        /// Gets the current elapsed time
        /// </summary>
        public TimeSpan ElapsedTime => _stopwatch.Elapsed;

        /// <summary>
        /// Gets whether the stopwatch is currently running
        /// </summary>
        public bool IsRunning => _stopwatch.IsRunning;

        /// <summary>
        /// Starts the stopwatch
        /// </summary>
        public void Start()
        {
            _stopwatch.Start();
        }

        /// <summary>
        /// Stops the stopwatch
        /// </summary>
        public void Stop()
        {
            _stopwatch.Stop();
        }

        /// <summary>
        /// Resets the stopwatch to zero
        /// </summary>
        public void Reset()
        {
            _stopwatch.Reset();
        }

        /// <summary>
        /// Gets the formatted time string in HH:MM:SS.fff format
        /// </summary>
        public string GetFormattedTime()
        {
            var elapsed = _stopwatch.Elapsed;
            return $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}.{elapsed.Milliseconds:000}";
        }
    }
}