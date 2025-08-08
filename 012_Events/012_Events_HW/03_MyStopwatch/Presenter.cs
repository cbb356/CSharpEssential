using System.Windows.Threading;

namespace MyStopwatch
{
    class Presenter
    {
        private Model model;
        private MainWindow view;
        private DispatcherTimer timer;
        
        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.view = mainWindow;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += UpdateTimeDisplay;

            this.view.StartEvent += new EventHandler(mainWindow_StartEvent);
            this.view.StopEvent += new EventHandler(mainWindow_StopEvent);
            this.view.ResetEvent += new EventHandler(mainWindow_ResetEvent);
        }

        private void UpdateTimeDisplay(object sender, EventArgs e)
        {
            view.TimeDisplay.Text = model.GetFormattedTime();
        }

        void mainWindow_StartEvent(object sender, System.EventArgs e)
        {
            model.Start();
            timer.Start();
        }

        void mainWindow_StopEvent(object sender, System.EventArgs e)
        {
            model.Stop();
            timer.Stop();
        }

        void mainWindow_ResetEvent(object sender, System.EventArgs e)
        {
            model.Reset();
            timer.Stop();
            this.UpdateTimeDisplay(sender, e);
        }
    }
}
