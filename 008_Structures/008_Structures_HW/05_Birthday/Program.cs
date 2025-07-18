namespace Birthday

/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
 * Реалізуйте програму, яка буде приймати від користувача дату його народження і 
 * виводити кількість днів до його наступного дня народження.
 */

{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday;

            Console.WriteLine("Enter your birthday (like 01.01.2000):");
            while(!DateTime.TryParse(Console.ReadLine(), out birthday))
            {
                Console.WriteLine("You entered incorrect date. Try again");
            }

            DateTime today = DateTime.Today;
            DateTime thisYearBirthday = new DateTime(today.Year, birthday.Month, birthday.Day);
            switch (DateTime.Compare(thisYearBirthday, today))
            {
                case 1:
                    Console.WriteLine($"Your birthday will be in {(thisYearBirthday - today).Days} days");
                    break;
                case -1:
                    Console.WriteLine($"Your birthday will be in {(thisYearBirthday.AddYears(1) - today).Days} days");
                    break;
                default:
                    Console.WriteLine("Today is your birthday! Congratulations!");
                    break;
            }

            //Delay
            Console.ReadKey();
        }
    }
}
