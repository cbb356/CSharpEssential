using System;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace MvpStopwatchGPT
{
    public partial class MainWindow : Window, IStopwatchView
    {
        public event Action StartClicked;
        public event Action StopClicked;
        public event Action ResetClicked;

        public MainWindow()
        {
            InitializeComponent();
            var model = new Model();
            var presenter = new Presenter(this, model);

            StartButton.Click += (s, e) => StartClicked?.Invoke();
            StopButton.Click += (s, e) => StopClicked?.Invoke();
            ResetButton.Click += (s, e) => ResetClicked?.Invoke();

            UpdateTimeDisplay("00:00:00.00");
        }

        public void UpdateTimeDisplay(string time)
        {
            TimeDisplay.Text = time;
        }
    }
}
