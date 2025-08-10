namespace MvpCalculatorGPT
{
    public class CalculatorPresenter
    {
        private readonly ICalculatorView view;
        private readonly CalculatorModel model;

        public CalculatorPresenter(ICalculatorView view, CalculatorModel model)
        {
            this.view = view;
            this.model = model;

            view.AddClicked += OnAdd;
            view.SubtractClicked += OnSubtract;
            view.MultiplyClicked += OnMultiply;
            view.DivideClicked += OnDivide;
        }

        private bool TryGetInputs(out double a, out double b)
        {
            if (!double.TryParse(view.FirstNumber, out a) ||
                !double.TryParse(view.SecondNumber, out b))
            {
                view.ShowError("Please enter valid numbers.");
                b = 0;
                return false;
            }
            return true;
        }

        private void OnAdd()
        {
            if (!TryGetInputs(out double a, out double b)) return;
            view.SetResult(model.Add(a, b).ToString());
        }

        private void OnSubtract()
        {
            if (!TryGetInputs(out double a, out double b)) return;
            view.SetResult(model.Subtract(a, b).ToString());
        }

        private void OnMultiply()
        {
            if (!TryGetInputs(out double a, out double b)) return;
            view.SetResult(model.Multiply(a, b).ToString());
        }

        private void OnDivide()
        {
            if (!TryGetInputs(out double a, out double b)) return;
            try
            {
                view.SetResult(model.Divide(a, b).ToString());
            }
            catch (DivideByZeroException ex)
            {
                view.ShowError(ex.Message);
            }
        }
    }
}
