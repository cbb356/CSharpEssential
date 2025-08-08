using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpStopwatchGPT
{
    public interface IStopwatchView
    {
        void UpdateTimeDisplay(string time);
        event Action StartClicked;
        event Action StopClicked;
        event Action ResetClicked;
    }
}
