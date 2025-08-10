using System;

namespace Calculator
{
    class Presenter
    {
        private Model model = null;
        private MainWindow view = null;

        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            view = mainWindow;
            view.AddClicked += new EventHandler(OnAdd);
            view.SubtractClicked += new EventHandler(OnSubtract);
            view.MultiplyClicked += new EventHandler(OnMultiply);
            view.DivideClicked += new EventHandler(OnDivide);
        }

        private bool TryGetInputs(out double x, out double y)
        {
            if (!double.TryParse(view.FirstNumber, out x) ||
                !double.TryParse(view.SecondNumber, out y))
            {
                view.ShowError("Please enter valid numbers");
                y = 0;
                return false;
            }
            return true;
        }

        void OnAdd(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double x, out double y))
            { 
                return;
            }
            view.SetResult(model.AddOperation(x, y).ToString());
        }

        void OnSubtract(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double x, out double y))
            {
                return;
            }
            view.SetResult(model.SubtractOperation(x, y).ToString());
        }

        void OnMultiply(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double x, out double y))
            {
                return;
            }
            view.SetResult(model.MultiplyOperation(x, y).ToString());
        }

        void OnDivide(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double x, out double y))
            {
                return;
            }

            try
            {
                view.SetResult(model.DivideOperation(x, y).ToString());
            }
            catch (DivideByZeroException ex)
            {
                view.ShowError(ex.Message);
            }
        }
    }
}
