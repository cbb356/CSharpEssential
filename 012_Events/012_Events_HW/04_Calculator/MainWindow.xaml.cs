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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string FirstNumber => FirstOperandTextBox.Text;
        public string SecondNumber => SecondOperandTextBox.Text;
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler AddClicked;
        public event EventHandler SubtractClicked;
        public event EventHandler MultiplyClicked;
        public event EventHandler DivideClicked;

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddClicked?.Invoke(sender, e);
        }

        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            SubtractClicked?.Invoke(sender, e);
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            MultiplyClicked?.Invoke(sender, e);
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            DivideClicked?.Invoke(sender, e);
        }

        public void SetResult(string result)
        {
            ResultTextBlock.Text = $"Result: {result}";
            ErrorTextBlock.Text = "";
        }

        public void ShowError(string message)
        {
            ErrorTextBlock.Text = message;
            ResultTextBlock.Text = "";
        }
    }
}