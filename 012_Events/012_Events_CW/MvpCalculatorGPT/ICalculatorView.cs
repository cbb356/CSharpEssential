namespace MvpCalculatorGPT
{
    public interface ICalculatorView
    {
        string FirstNumber { get; }
        string SecondNumber { get; }
        void SetResult(string result);
        void ShowError(string message);

        event Action AddClicked;
        event Action SubtractClicked;
        event Action MultiplyClicked;
        event Action DivideClicked;
    }
}
