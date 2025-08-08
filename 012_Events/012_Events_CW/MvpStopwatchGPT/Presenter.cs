using System;

namespace MvpStopwatchGPT
{
    public class Presenter
    {
        private readonly IStopwatchView view;
        private readonly Model model;

        public Presenter(IStopwatchView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.StartClicked += OnStart;
            this.view.StopClicked += OnStop;
            this.view.ResetClicked += OnReset;
            this.model.TimeUpdated += OnTimeUpdated;
        }

        private void OnStart() => model.Start();
        private void OnStop() => model.Stop();
        private void OnReset() => model.Reset();
        private void OnTimeUpdated(TimeSpan time) =>
            view.UpdateTimeDisplay(time.ToString(@"hh\:mm\:ss\.ff"));
    }
}
