using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculatorGemini
{
    public class CalculatorPresenter
    {
        private readonly ICalculatorView _view;
        private readonly CalculatorModel _model;

        private string _operand1 = "";
        private string _operand2 = "";
        private string _operator = "";
        private bool _isEnteringSecondOperand = false;

        public CalculatorPresenter(ICalculatorView view, CalculatorModel model)
        {
            _view = view;
            _model = model;

            // Subscribe to the View's events
            _view.NumberClicked += OnNumberClicked;
            _view.OperatorClicked += OnOperatorClicked;
            _view.EqualsClicked += OnEqualsClicked;
            _view.ClearClicked += OnClearClicked;
        }

        private void OnNumberClicked(string number)
        {
            if (_isEnteringSecondOperand)
            {
                _operand2 += number;
                _view.DisplayText = _operand2;
            }
            else
            {
                _operand1 += number;
                _view.DisplayText = _operand1;
            }
        }

        private void OnOperatorClicked(string op)
        {
            _operator = op;
            _isEnteringSecondOperand = true;
        }

        private void OnEqualsClicked()
        {
            if (string.IsNullOrEmpty(_operand1) || string.IsNullOrEmpty(_operand2) || string.IsNullOrEmpty(_operator))
                return;

            try
            {
                double op1 = double.Parse(_operand1);
                double op2 = double.Parse(_operand2);

                double result = _model.Calculate(op1, op2, _operator);
                _view.DisplayText = result.ToString();

                // Prepare for next calculation
                _operand1 = result.ToString();
                _operand2 = "";
                _isEnteringSecondOperand = false;
            }
            catch (Exception ex)
            {
                _view.DisplayText = "Error";
                // Optionally log ex.Message
                ResetState();
            }
        }

        private void OnClearClicked()
        {
            ResetState();
            _view.DisplayText = "0";
        }

        private void ResetState()
        {
            _operand1 = "";
            _operand2 = "";
            _operator = "";
            _isEnteringSecondOperand = false;
        }
    }
}
