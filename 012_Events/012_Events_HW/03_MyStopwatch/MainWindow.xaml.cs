using System.Windows;

namespace MyStopwatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public string DisplayTime
        {
            set { TimeDisplay.Text = value; }
        }

        public event EventHandler StartEvent = null;
        public event EventHandler StopEvent = null;
        public event EventHandler ResetEvent = null;

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            StartEvent?.Invoke(sender, e);
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            StopEvent?.Invoke(sender, e);
        }

        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            ResetEvent?.Invoke(sender, e);
        }
    }
}