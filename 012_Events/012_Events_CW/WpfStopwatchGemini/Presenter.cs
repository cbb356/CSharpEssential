namespace WpfStopwatchGemini
{
    public class Presenter
    {
        private readonly IStopwatchView _view;
        private readonly Model _model;

        public Presenter(IStopwatchView view, Model model)
        {
            _view = view;
            _model = model;

            // Subscribe to events from the View and Model
            _view.StartClicked += OnStartClicked;
            _view.StopClicked += OnStopClicked;
            _view.ResetClicked += OnResetClicked;
            _model.TimeUpdated += OnTimeUpdated;
        }

        // --- Event Handlers ---

        private void OnStartClicked()
        {
            _model.Start();
        }

        private void OnStopClicked()
        {
            _model.Stop();
        }

        private void OnResetClicked()
        {
            _model.Reset();
        }

        private void OnTimeUpdated(TimeSpan elapsedTime)
        {
            // Format the TimeSpan and update the View
            _view.DisplayTime = elapsedTime.ToString(@"mm\:ss\.f");
        }
    }
}
