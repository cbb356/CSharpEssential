using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculatorGemini
{
    public class CalculatorModel
    {
        public double Calculate(double operand1, double operand2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "*":
                    return operand1 * operand2;
                case "/":
                    if (operand2 == 0)
                        throw new DivideByZeroException("Cannot divide by zero.");
                    return operand1 / operand2;
                default:
                    throw new ArgumentException("Invalid operation", nameof(operation));
            }
        }
    }
}
