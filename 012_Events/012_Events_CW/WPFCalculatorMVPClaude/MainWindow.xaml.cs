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

namespace WPFCalculatorMVPClaude
{
    /// <summary>
    /// Main Window implementing the ICalculatorView interface
    /// </summary>
    public partial class MainWindow : Window, ICalculatorView
    {
        private CalculatorPresenter _presenter;

        public MainWindow()
        {
            InitializeComponent();
            InitializePresenter();
            SetupKeyboardSupport();
        }

        private void InitializePresenter()
        {
            _presenter = new CalculatorPresenter(this);
        }

        private void SetupKeyboardSupport()
        {
            this.KeyDown += MainWindow_KeyDown;
            this.Focusable = true;
            this.Focus();
        }

        #region ICalculatorView Implementation

        public event EventHandler<string> NumberClicked;
        public event EventHandler AddClicked;
        public event EventHandler SubtractClicked;
        public event EventHandler MultiplyClicked;
        public event EventHandler DivideClicked;
        public event EventHandler EqualsClicked;
        public event EventHandler ClearClicked;
        public event EventHandler ClearEntryClicked;
        public event EventHandler DecimalClicked;
        public event EventHandler BackspaceClicked;
        public event EventHandler ChangeSignClicked;

        public string DisplayText
        {
            get => DisplayLabel.Content?.ToString() ?? "0";
            set => DisplayLabel.Content = value;
        }

        public void ShowError(string message)
        {
            DisplayLabel.Foreground = Brushes.Red;
        }

        public void ClearError()
        {
            DisplayLabel.Foreground = Brushes.Black;
        }

        #endregion

        #region Button Event Handlers

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                NumberClicked?.Invoke(this, button.Content.ToString());
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddClicked?.Invoke(this, EventArgs.Empty);
        }

        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            SubtractClicked?.Invoke(this, EventArgs.Empty);
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            MultiplyClicked?.Invoke(this, EventArgs.Empty);
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            DivideClicked?.Invoke(this, EventArgs.Empty);
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            EqualsClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ClearEntryButton_Click(object sender, RoutedEventArgs e)
        {
            ClearEntryClicked?.Invoke(this, EventArgs.Empty);
        }

        private void DecimalButton_Click(object sender, RoutedEventArgs e)
        {
            DecimalClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BackspaceButton_Click(object sender, RoutedEventArgs e)
        {
            BackspaceClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ChangeSignButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeSignClicked?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        #region Keyboard Support

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.D0:
                case Key.NumPad0:
                    NumberClicked?.Invoke(this, "0");
                    break;
                case Key.D1:
                case Key.NumPad1:
                    NumberClicked?.Invoke(this, "1");
                    break;
                case Key.D2:
                case Key.NumPad2:
                    NumberClicked?.Invoke(this, "2");
                    break;
                case Key.D3:
                case Key.NumPad3:
                    NumberClicked?.Invoke(this, "3");
                    break;
                case Key.D4:
                case Key.NumPad4:
                    NumberClicked?.Invoke(this, "4");
                    break;
                case Key.D5:
                case Key.NumPad5:
                    NumberClicked?.Invoke(this, "5");
                    break;
                case Key.D6:
                case Key.NumPad6:
                    NumberClicked?.Invoke(this, "6");
                    break;
                case Key.D7:
                case Key.NumPad7:
                    NumberClicked?.Invoke(this, "7");
                    break;
                case Key.D8:
                case Key.NumPad8:
                    NumberClicked?.Invoke(this, "8");
                    break;
                case Key.D9:
                case Key.NumPad9:
                    NumberClicked?.Invoke(this, "9");
                    break;
                case Key.Add:
                    AddClicked?.Invoke(this, EventArgs.Empty);
                    break;
                case Key.Subtract:
                    SubtractClicked?.Invoke(this, EventArgs.Empty);
                    break;
                case Key.Multiply:
                    MultiplyClicked?.Invoke(this, EventArgs.Empty);
                    break;
                case Key.Divide:
                    DivideClicked?.Invoke(this, EventArgs.Empty);
                    break;
                case Key.Enter:
                    EqualsClicked?.Invoke(this, EventArgs.Empty);
                    break;
                case Key.Decimal:
                case Key.OemPeriod:
                case Key.OemComma:
                    DecimalClicked?.Invoke(this, EventArgs.Empty);
                    break;
                case Key.Back:
                    BackspaceClicked?.Invoke(this, EventArgs.Empty);
                    break;
                case Key.Escape:
                    ClearClicked?.Invoke(this, EventArgs.Empty);
                    break;
                case Key.Delete:
                    ClearEntryClicked?.Invoke(this, EventArgs.Empty);
                    break;
            }
        }

        #endregion
    }
}