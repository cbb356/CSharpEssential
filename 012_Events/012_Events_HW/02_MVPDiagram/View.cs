namespace MVPDiagram
{
    public class View
    {
        public void Display(string message)
        {
            Console.WriteLine(message);
        }

        public event Action OnAction;

        public void TriggerAction()
        {
            OnAction?.Invoke();
        }
    }
}
