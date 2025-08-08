namespace WpfStopwatchGemini
{
    public interface IStopwatchView
    {
        // A property the Presenter can use to update the time display
        string DisplayTime { set; }

        // Events that the View will raise when buttons are clicked
        event Action StartClicked;
        event Action StopClicked;
        event Action ResetClicked;
    }
}
