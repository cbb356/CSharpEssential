using System.Windows.Threading;

namespace MVPStopwatchClaude
{
    internal class Presenter
    {
        private readonly IStopwatchView _view;
        private readonly Model _model;
        private readonly DispatcherTimer _uiTimer;

        public Presenter(IStopwatchView view, Model model)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _model = model ?? throw new ArgumentNullException(nameof(model));

            // Subscribe to view events
            _view.StartClicked += OnStartClicked;
            _view.StopClicked += OnStopClicked;
            _view.ResetClicked += OnResetClicked;

            // Setup UI update timer
            _uiTimer = new DispatcherTimer();
            _uiTimer.Interval = TimeSpan.FromMilliseconds(10); // Update every 10ms for smooth display
            _uiTimer.Tick += OnTimerTick;

            // Initialize the view
            UpdateView();
        }

        private void OnStartClicked(object sender, EventArgs e)
        {
            if (_model.IsRunning)
            {
                // If running, this acts as a pause button
                _model.Stop();
                _uiTimer.Stop();
                _view.ShowMessage("Stopwatch paused");
            }
            else
            {
                // If stopped, start the stopwatch
                _model.Start();
                _uiTimer.Start();
                _view.ShowMessage("Stopwatch started");
            }
            UpdateView();
        }

        private void OnStopClicked(object sender, EventArgs e)
        {
            _model.Stop();
            _uiTimer.Stop();
            _view.ShowMessage("Stopwatch stopped");
            UpdateView();
        }

        private void OnResetClicked(object sender, EventArgs e)
        {
            _model.Stop();
            _model.Reset();
            _uiTimer.Stop();
            _view.ShowMessage("Stopwatch reset");
            UpdateView();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            UpdateTimeDisplay();
        }

        private void UpdateView()
        {
            UpdateTimeDisplay();
            UpdateButtons();
        }

        private void UpdateTimeDisplay()
        {
            _view.TimeDisplay = _model.GetFormattedTime();
        }

        private void UpdateButtons()
        {
            // Start button: always enabled, text changes based on state
            _view.StartButtonEnabled = true;
            _view.StartButtonText = _model.IsRunning ? "Pause" : "Start";

            // Stop button: only enabled when running
            _view.StopButtonEnabled = _model.IsRunning;

            // Reset button: always enabled
            _view.ResetButtonEnabled = true;
        }
    }
}
