namespace Classes
{ 
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public DateTime StartEmployment { get; set; }

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

        public int Tenure()
        {
            DateTime endDate = DateTime.Now;
            int years = endDate.Year - StartEmployment.Year;

            if (StartEmployment.Month > endDate.Month || (StartEmployment.Month == endDate.Month && StartEmployment.Day > endDate.Day))
            {
                years--;
            }
            return years;
        }

        public void ShowEmployeerInfo()
        {
            int tenure = Tenure();
            double salary = GetBaseSalary(Position) * (1 + BONUS_RATE * tenure);
            Console.WriteLine($"{Position} {FirstName} {LastName} has been working for {tenure} years");
            Console.WriteLine($"The employeer has a salary of {salary:F2}, and the tax due is {salary * TAX_RATE:F2}");
        }
    }
}
