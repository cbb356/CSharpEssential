using System.Windows;
using System.Windows.Controls;

namespace WpfCalculatorGemini
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window, ICalculatorView
    {
        private readonly CalculatorPresenter _presenter;

        public MainWindow()
        {
            InitializeComponent();
            var model = new CalculatorModel();
            _presenter = new CalculatorPresenter(this, model);
        }

        #region ICalculatorView Implementation

        public string DisplayText
        {
            get => Display.Text;
            set => Display.Text = value;
        }

        public event Action<string> NumberClicked;
        public event Action<string> OperatorClicked;
        public event Action EqualsClicked;
        public event Action ClearClicked;

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string content = button.Content.ToString();

                if (int.TryParse(content, out _))
                {
                    NumberClicked?.Invoke(content);
                }
                else
                {
                    switch (content)
                    {
                        case "+":
                        case "-":
                        case "*":
                        case "/":
                            OperatorClicked?.Invoke(content);
                            break;
                        case "=":
                            EqualsClicked?.Invoke();
                            break;
                        case "C":
                            ClearClicked?.Invoke();
                            break;
                    }
                }
            }
        }
    }
}