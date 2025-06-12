namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee ceo = new Employee("John", "Doe")
            {
                Position = "CEO",
                Tenure = 12
            };
            ceo.ShowEmployeerInfo();

            Employee manager = new Employee("Sarah", "Connor")
            {
                Position = "Manager",
                Tenure = 8
            };
            manager.ShowEmployeerInfo();

            Employee engineer = new Employee("Peter", "O'Brien")
            {
                Position = "Engineer",
                Tenure = 10
            };
            engineer.ShowEmployeerInfo();

            Employee worker = new Employee("Jack", "Smith")
            {
                Position = "Worker",
                Tenure = 3
            };
            worker.ShowEmployeerInfo();

            Employee intern = new Employee("Donald", "Trump")
            {
                Position = "Intern",
                Tenure = 0
            };
            intern.ShowEmployeerInfo();

            //Delay
            Console.ReadKey();
        }
    }
}
