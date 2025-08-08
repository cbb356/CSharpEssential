using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPStopwatchClaude
{
    public interface IStopwatchView
    {
        // Events that the View raises to notify the Presenter
        event EventHandler StartClicked;
        event EventHandler StopClicked;
        event EventHandler ResetClicked;

        // Properties and methods that the Presenter uses to update the View
        string TimeDisplay { get; set; }
        bool StartButtonEnabled { get; set; }
        bool StopButtonEnabled { get; set; }
        bool ResetButtonEnabled { get; set; }
        string StartButtonText { get; set; }

        void ShowMessage(string message);
    }
}
