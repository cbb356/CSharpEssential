namespace Notebook
{
    /*
     * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Створіть структуру з ім'ям – Notebook. Поля структури: модель, виробник, вартість. 
     * У структурі має бути реалізований конструктор для ініціалізації полів 
     * та метод для виведення вмісту полів на екран.
     */

    internal class Program
    {
        internal struct Notebook
        {
            private string model;
            private string manufaturer;
            private double price;

            public Notebook(string model, string manufaturer, double price)
            {
                this.model = model;
                this.manufaturer = manufaturer;
                this.price = price;
            }

            public void NotebookInfo()
            {
                Console.WriteLine($"Details of the notebook:\nModel: {model}\nManufacturer: {manufaturer}\nPrice: {price} USD");
            }
        }
        
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("IML1286", "Lenovo", 980.75);
            notebook.NotebookInfo();

            // Delay.
            Console.ReadKey();
        }
    }
}
