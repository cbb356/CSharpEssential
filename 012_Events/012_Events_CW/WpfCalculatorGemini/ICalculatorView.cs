using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculatorGemini
{
    public interface ICalculatorView
    {
        string DisplayText { get; set; }

        event Action<string> NumberClicked;
        event Action<string> OperatorClicked;
        event Action EqualsClicked;
        event Action ClearClicked;
    }
}
