namespace Classes
{ 
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Tenure { get; set; }

        private const double TAX_RATE = 0.15;
        private const double BONUS_RATE = 0.1;

        public Employee(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public double GetBaseSalary(string position)
        {
            double baseSalary = position switch
            {
                "CEO" => 5000,
                "Manager" => 3000,
                "Engineer" => 2000,
                "Worker" => 1000,
                _ => 500
            };

            return baseSalary;
        }

        public void ShowEmployeerInfo()
        {
            double salary = GetBaseSalary(Position) * (1 + BONUS_RATE * Tenure);
            Console.WriteLine($"{Position} {FirstName} {LastName} has a salary of {salary}, and the tax due is {salary * TAX_RATE}");
        }
    }
}
