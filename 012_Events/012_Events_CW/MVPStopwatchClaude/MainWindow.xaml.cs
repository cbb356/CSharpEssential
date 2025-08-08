using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVPStopwatchClaude
{
    /// <summary>
    /// Main Window that implements the IStopwatchView interface
    /// Contains only UI-related code, no business logic
    /// </summary>
    public partial class MainWindow : Window, IStopwatchView
    {
        private Presenter _presenter;

        public MainWindow()
        {
            InitializeComponent();
            InitializePresenter();
        }

        private void InitializePresenter()
        {
            // Create the model
            var model = new Model();

            // Create the presenter with this view and the model
            _presenter = new Presenter(this, model);
        }

        #region IStopwatchView Implementation

        // Events that notify the presenter of user actions
        public event EventHandler StartClicked;
        public event EventHandler StopClicked;
        public event EventHandler ResetClicked;

        // Properties for the presenter to update the UI
        public string TimeDisplay
        {
            get => TimeDisplayLabel.Content?.ToString() ?? "00:00:00.000";
            set => TimeDisplayLabel.Content = value;
        }

        public bool StartButtonEnabled
        {
            get => StartButton.IsEnabled;
            set => StartButton.IsEnabled = value;
        }

        public bool StopButtonEnabled
        {
            get => StopButton.IsEnabled;
            set => StopButton.IsEnabled = value;
        }

        public bool ResetButtonEnabled
        {
            get => ResetButton.IsEnabled;
            set => ResetButton.IsEnabled = value;
        }

        public string StartButtonText
        {
            get => StartButton.Content?.ToString() ?? "Start";
            set => StartButton.Content = value;
        }

        public void ShowMessage(string message)
        {
            StatusLabel.Content = $"Status: {message}";
        }

        #endregion

        #region Button Event Handlers

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartClicked?.Invoke(this, EventArgs.Empty);
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            StopClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            ResetClicked?.Invoke(this, EventArgs.Empty);
        }

        #endregion
        }
    }