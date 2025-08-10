using System.Windows.Threading;
using System;

namespace MyStopwatch
{
    class Presenter
    {
        private Model model;
        private MainWindow view;
        private DispatcherTimer timer;
        
        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            view = mainWindow;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += UpdateTimeDisplay;

            view.StartEvent += new EventHandler(MainWindow_StartEvent);
            view.StopEvent += new EventHandler(MainWindow_StopEvent);
            view.ResetEvent += new EventHandler(MainWindow_ResetEvent);
        }

        private void UpdateTimeDisplay(object sender, EventArgs e)
        {
            view.TimeDisplay.Text = model.GetFormattedTime();
        }

        void MainWindow_StartEvent(object sender, EventArgs e)
        {
            model.Start();
            timer.Start();
        }

        void MainWindow_StopEvent(object sender, EventArgs e)
        {
            model.Stop();
            timer.Stop();
        }

        void MainWindow_ResetEvent(object sender, EventArgs e)
        {
            model.Reset();
            timer.Stop();
            UpdateTimeDisplay(sender, e);
        }
    }
}
