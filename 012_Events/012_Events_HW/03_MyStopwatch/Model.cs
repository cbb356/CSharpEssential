using System.Diagnostics;
using System.Windows.Threading;

namespace MyStopwatch
{
    class Model
    {
        private DateTime startTime;
        private TimeSpan totalTime;
        private bool isRunning;

        public void Start()
        {
            if (!isRunning)
            {
                startTime = DateTime.Now;
                isRunning = true;
            }
        }

        public void Stop()
        {
            if (isRunning)
            {
                totalTime += DateTime.Now - startTime;
                isRunning = false;
            }
        }

        public void Reset()
        {
            isRunning = false;
            totalTime = TimeSpan.Zero;
        }

        public TimeSpan GetTotalTime()
        { 
            if (isRunning)
            {
                return totalTime + (DateTime.Now - startTime);
            }
            return totalTime;
        }

        public string GetFormattedTime()
        {
            return GetTotalTime().ToString(@"hh\:mm\:ss\.ff");
        }
    }
}
