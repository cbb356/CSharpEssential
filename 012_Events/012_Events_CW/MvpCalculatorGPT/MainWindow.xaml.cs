using System.Windows;

namespace MvpCalculatorGPT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ICalculatorView
    {
        public string FirstNumber => FirstNumberTextBox.Text;
        public string SecondNumber => SecondNumberTextBox.Text;

        public event Action AddClicked;
        public event Action SubtractClicked;
        public event Action MultiplyClicked;
        public event Action DivideClicked;

        public MainWindow()
        {
            InitializeComponent();
            var model = new CalculatorModel();
            var presenter = new CalculatorPresenter(this, model);

            AddButton.Click += (s, e) => AddClicked?.Invoke();
            SubtractButton.Click += (s, e) => SubtractClicked?.Invoke();
            MultiplyButton.Click += (s, e) => MultiplyClicked?.Invoke();
            DivideButton.Click += (s, e) => DivideClicked?.Invoke();
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