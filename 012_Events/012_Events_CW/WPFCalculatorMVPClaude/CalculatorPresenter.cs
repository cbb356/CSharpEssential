namespace WPFCalculatorMVPClaude
{
    /// <summary>
    /// Presenter class that coordinates between Model and View
    /// Contains all the application logic
    /// </summary>
    public class CalculatorPresenter
    {
        private readonly ICalculatorView _view;
        private readonly CalculatorModel _model;

        public CalculatorPresenter(ICalculatorView view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _model = new CalculatorModel();

            SubscribeToViewEvents();
            UpdateDisplay();
        }

        private void SubscribeToViewEvents()
        {
            // Number button events
            _view.NumberClicked += OnNumberClicked;
            
            // Operation button events
            _view.AddClicked += (s, e) => OnOperationClicked(Operation.Add);
            _view.SubtractClicked += (s, e) => OnOperationClicked(Operation.Subtract);
            _view.MultiplyClicked += (s, e) => OnOperationClicked(Operation.Multiply);
            _view.DivideClicked += (s, e) => OnOperationClicked(Operation.Divide);
            
            // Special button events
            _view.EqualsClicked += OnEqualsClicked;
            _view.ClearClicked += OnClearClicked;
            _view.ClearEntryClicked += OnClearEntryClicked;
            _view.DecimalClicked += OnDecimalClicked;
            _view.BackspaceClicked += OnBackspaceClicked;
            _view.ChangeSignClicked += OnChangeSignClicked;
        }

        private void OnNumberClicked(object sender, string digit)
        {
            _view.ClearError();
            _model.AppendDigit(digit);
            UpdateDisplay();
        }

        private void OnOperationClicked(Operation operation)
        {
            _view.ClearError();
            _model.SetOperation(operation);
            UpdateDisplay();
        }

        private void OnEqualsClicked(object sender, EventArgs e)
        {
            _view.ClearError();
            string result = _model.Calculate();
            
            if (result.Contains("Error") || result.Contains("Cannot"))
            {
                _view.ShowError(result);
            }
            
            UpdateDisplay();
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            _view.ClearError();
            _model.Clear();
            UpdateDisplay();
        }

        private void OnClearEntryClicked(object sender, EventArgs e)
        {
            _view.ClearError();
            _model.ClearEntry();
            UpdateDisplay();
        }

        private void OnDecimalClicked(object sender, EventArgs e)
        {
            _view.ClearError();
            _model.AppendDecimal();
            UpdateDisplay();
        }

        private void OnBackspaceClicked(object sender, EventArgs e)
        {
            _view.ClearError();
            _model.Backspace();
            UpdateDisplay();
        }

        private void OnChangeSignClicked(object sender, EventArgs e)
        {
            _view.ClearError();
            _model.ChangeSign();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            _view.DisplayText = _model.CurrentDisplay;
        }
    }
}
