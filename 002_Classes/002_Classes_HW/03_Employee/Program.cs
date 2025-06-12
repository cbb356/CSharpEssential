namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee ceo = new Employee("John", "Doe")
            {
                Position = "CEO",
                StartEmployment = new DateTime(2013, 4, 16)
            };
            ceo.ShowEmployeerInfo();
            Console.WriteLine();

            Employee manager = new Employee("Sarah", "Connor")
            {
                Position = "Manager",
                StartEmployment = new DateTime(2017, 10, 5)
            };
            manager.ShowEmployeerInfo();
            Console.WriteLine();

            Employee engineer = new Employee("Peter", "O'Brien")
            {
                Position = "Engineer",
                StartEmployment = new DateTime(2015, 6, 10)
            };
            engineer.ShowEmployeerInfo();
            Console.WriteLine();

            Employee worker = new Employee("Jack", "Smith")
            {
                Position = "Worker",
                StartEmployment = new DateTime(2022, 2, 24)
            };
            worker.ShowEmployeerInfo();
            Console.WriteLine();

            Employee intern = new Employee("Donald", "Duck")
            {
                Position = "Intern",
                StartEmployment = new DateTime(2025, 5, 12)
            };
            intern.ShowEmployeerInfo();
            Console.WriteLine();

            //Delay
            Console.ReadKey();
        }
    }
}
