namespace MVPDiagram
{
    public class Presenter
    {
        private View view;
        private Model model;

        public Presenter(View view, Model model)
        {
            this.view = view;
            this.model = model;

            view.OnAction += HandleAction;
        }

        public View View
        {
            get => default;
            set
            {
            }
        }

        public Model Model
        {
            get => default;
            set
            {
            }
        }

        private void HandleAction()
        {
            var data = model.GetData();
            view.Display(data);
        }
    }
}
