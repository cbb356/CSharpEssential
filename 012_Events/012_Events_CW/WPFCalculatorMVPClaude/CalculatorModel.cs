namespace WPFCalculatorMVPClaude
{
    /// <summary>
    /// Enumeration for calculator operations
    /// </summary>
    public enum Operation
    {
        None,
        Add,
        Subtract,
        Multiply,
        Divide
    }

    /// <summary>
    /// Model class containing calculator logic and state
    /// </summary>
    public class CalculatorModel
    {
        private double _firstOperand;
        private double _secondOperand;
        private Operation _operation;
        private bool _isNewCalculation;
        private bool _operationPressed;
        private string _currentDisplay;

        public CalculatorModel()
        {
            Clear();
        }

        /// <summary>
        /// Gets the current display value
        /// </summary>
        public string CurrentDisplay => _currentDisplay;

        /// <summary>
        /// Gets whether we're starting a new calculation
        /// </summary>
        public bool IsNewCalculation => _isNewCalculation;

        /// <summary>
        /// Appends a digit to the current number
        /// </summary>
        public void AppendDigit(string digit)
        {
            // If we're showing an error, clear it when starting new input
            if (_currentDisplay.Contains("Error") || _currentDisplay.Contains("Cannot"))
            {
                Clear();
            }

            if (_isNewCalculation || _operationPressed)
            {
                _currentDisplay = digit;
                _isNewCalculation = false;
                _operationPressed = false;
            }
            else
            {
                if (_currentDisplay == "0" && digit != ".")
                {
                    _currentDisplay = digit;
                }
                else
                {
                    _currentDisplay += digit;
                }
            }
        }

        /// <summary>
        /// Appends decimal point
        /// </summary>
        public void AppendDecimal()
        {
            // If we're showing an error, clear it when starting new input
            if (_currentDisplay.Contains("Error") || _currentDisplay.Contains("Cannot"))
            {
                Clear();
            }

            if (_isNewCalculation || _operationPressed)
            {
                // Use current culture's decimal separator
                string decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                _currentDisplay = "0" + decimalSeparator;
                _isNewCalculation = false;
                _operationPressed = false;
            }
            else
            {
                string decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                if (!_currentDisplay.Contains(decimalSeparator))
                {
                    _currentDisplay += decimalSeparator;
                }
            }
        }

        /// <summary>
        /// Sets the operation to perform
        /// </summary>
        public void SetOperation(Operation operation)
        {
            // If we're showing an error, clear it when starting new operation
            if (_currentDisplay.Contains("Error") || _currentDisplay.Contains("Cannot"))
            {
                Clear();
                _firstOperand = 0;
            }
            else if (!_isNewCalculation && _operation != Operation.None && !_operationPressed)
            {
                // Chain operations - calculate current result first
                Calculate();
            }
            else
            {
                _firstOperand = ParseCurrentDisplay();
            }

            _operation = operation;
            _operationPressed = true;
        }

        /// <summary>
        /// Performs the calculation
        /// </summary>
        public string Calculate()
        {
            if (_operation == Operation.None)
            {
                // No operation pending, just return current display
                return _currentDisplay;
            }

            // If we're showing an error, don't calculate
            if (_currentDisplay.Contains("Error") || _currentDisplay.Contains("Cannot"))
            {
                return _currentDisplay;
            }

            _secondOperand = ParseCurrentDisplay();
            double result = 0;
            bool hasError = false;
            string errorMessage = "";

            try
            {
                switch (_operation)
                {
                    case Operation.Add:
                        result = _firstOperand + _secondOperand;
                        break;
                    case Operation.Subtract:
                        result = _firstOperand - _secondOperand;
                        break;
                    case Operation.Multiply:
                        result = _firstOperand * _secondOperand;
                        break;
                    case Operation.Divide:
                        if (_secondOperand == 0)
                        {
                            hasError = true;
                            errorMessage = "Cannot divide by zero";
                        }
                        else
                        {
                            result = _firstOperand / _secondOperand;
                        }
                        break;
                }

                if (hasError)
                {
                    _currentDisplay = errorMessage;
                    _operation = Operation.None;
                    _isNewCalculation = true;
                    _operationPressed = false;
                    // Don't call Clear() here - keep the error message visible
                    return errorMessage;
                }

                // Handle very large or very small numbers
                if (double.IsInfinity(result) || double.IsNaN(result))
                {
                    _currentDisplay = "Error";
                    _operation = Operation.None;
                    _isNewCalculation = true;
                    _operationPressed = false;
                    // Don't call Clear() here - keep the error message visible
                    return "Error";
                }

                // Format the result
                _currentDisplay = FormatResult(result);
                _firstOperand = result;
                _operation = Operation.None;
                _isNewCalculation = true;
                _operationPressed = false;

                return _currentDisplay;
            }
            catch (Exception)
            {
                _currentDisplay = "Error";
                _operation = Operation.None;
                _isNewCalculation = true;
                _operationPressed = false;
                // Don't call Clear() here - keep the error message visible
                return "Error";
            }
        }

        /// <summary>
        /// Clears the calculator
        /// </summary>
        public void Clear()
        {
            _firstOperand = 0;
            _secondOperand = 0;
            _operation = Operation.None;
            _currentDisplay = "0";
            _isNewCalculation = true;
            _operationPressed = false;
        }

        /// <summary>
        /// Clears the current entry
        /// </summary>
        public void ClearEntry()
        {
            _currentDisplay = "0";
        }

        /// <summary>
        /// Removes the last digit
        /// </summary>
        public void Backspace()
        {
            if (_currentDisplay.Length > 1)
            {
                _currentDisplay = _currentDisplay.Substring(0, _currentDisplay.Length - 1);
            }
            else
            {
                _currentDisplay = "0";
            }
        }

        /// <summary>
        /// Changes the sign of the current number
        /// </summary>
        public void ChangeSign()
        {
            double value = ParseCurrentDisplay();
            value = -value;
            _currentDisplay = FormatResult(value);
        }

        private double ParseCurrentDisplay()
        {
            // Use current culture for parsing to handle regional decimal separators
            if (double.TryParse(_currentDisplay, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.CurrentCulture, out double result))
            {
                return result;
            }
            return 0;
        }

        private string FormatResult(double result)
        {
            // Handle integer results
            if (result == Math.Floor(result) && !double.IsInfinity(result))
            {
                return result.ToString("0");
            }

            // Handle decimal results - limit to 10 decimal places
            string formatted = result.ToString("0.##########");

            // Handle very large or small numbers with scientific notation
            if (Math.Abs(result) >= 1e10 || (Math.Abs(result) <= 1e-6 && result != 0))
            {
                formatted = result.ToString("0.###e+0");
            }

            return formatted;
        }
    }
}
