namespace WPFCalculatorMVPClaude
{
    /// <summary>
    /// Interface defining the contract between View and Presenter
    /// </summary>
    public interface ICalculatorView
    {
        // Events for number buttons (0-9)
        event EventHandler<string> NumberClicked;

        // Events for operation buttons
        event EventHandler AddClicked;
        event EventHandler SubtractClicked;
        event EventHandler MultiplyClicked;
        event EventHandler DivideClicked;

        // Events for special buttons
        event EventHandler EqualsClicked;
        event EventHandler ClearClicked;
        event EventHandler ClearEntryClicked;
        event EventHandler DecimalClicked;
        event EventHandler BackspaceClicked;
        event EventHandler ChangeSignClicked;

        // Properties for updating the view
        string DisplayText { get; set; }
        void ShowError(string message);
        void ClearError();
    }
}
