using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfStopwatchGemini
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IStopwatchView
    {
        private readonly Presenter _presenter;

        public MainWindow()
        {
            InitializeComponent();
            // Create the model and presenter, wiring them up to this view.
            var model = new Model();
            _presenter = new Presenter(this, model);
        }

        #region IStopwatchView Implementation

        public string DisplayTime
        {
            set { TimeDisplay.Text = value; }
        }

        public event Action StartClicked;
        public event Action StopClicked;
        public event Action ResetClicked;

        #endregion

        #region UI Event Handlers

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartClicked?.Invoke();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            StopClicked?.Invoke();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            ResetClicked?.Invoke();
        }

        #endregion
    }
}