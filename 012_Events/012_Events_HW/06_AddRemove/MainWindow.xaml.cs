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

namespace AddRemove
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

        private EventHandler myEventDelegate;

        public event EventHandler myEvent
        {
            add
            {
                myEventDelegate += value;
                System.Diagnostics.Debug.WriteLine("The handler added");
            }
            remove
            {
                myEventDelegate -= value;
                System.Diagnostics.Debug.WriteLine("The handler removed");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            myEventDelegate?.Invoke(sender, e);
        }
    }
}