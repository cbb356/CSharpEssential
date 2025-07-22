namespace Accountant

/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
 * Створіть перелік, який містить посади співробітників як імена констант. 
 * Надайте кожній константі значення, що задає кількість годин, які повинен відпрацювати 
 * співробітник протягом місяця. Створіть клас Accountant 
 * з методом bool AskForBonus (Post worker, int hours), 
 * що відображатиме давати співробітнику премію. 
 * Якщо співробітник відпрацював більше годин на місяць, то йому належить премія.
 */

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post director = Post.Director;
            Post manager = Post.Manager;
            Post worker = Post.Worker;
            Post intern = Post.Intern;
            int lastMonthWorkHours;

            lastMonthWorkHours = 210;
            Console.WriteLine($"The {director} who had worked {lastMonthWorkHours} hours last month will obtain the bonus payment: {Accountant.AskForBonus(director, lastMonthWorkHours)}");
            Console.WriteLine($"The {manager} who had worked {lastMonthWorkHours} hours last month will obtain the bonus payment: {Accountant.AskForBonus(manager, lastMonthWorkHours)}");
            Console.WriteLine($"The {worker} who had worked {lastMonthWorkHours} hours last month will obtain the bonus payment: {Accountant.AskForBonus(worker, lastMonthWorkHours)}");
            Console.WriteLine($"The {intern} who had worked {lastMonthWorkHours} hours last month will obtain the bonus payment: {Accountant.AskForBonus(intern, lastMonthWorkHours)}");
            lastMonthWorkHours = 185;
            Console.WriteLine($"The {director} who had worked {lastMonthWorkHours} hours last month will obtain the bonus payment: {Accountant.AskForBonus(director, lastMonthWorkHours)}");
            Console.WriteLine($"The {manager} who had worked {lastMonthWorkHours} hours last month will obtain the bonus payment: {Accountant.AskForBonus(manager, lastMonthWorkHours)}");
            Console.WriteLine($"The {worker} who had worked {lastMonthWorkHours} hours last month will obtain the bonus payment: {Accountant.AskForBonus(worker, lastMonthWorkHours)}");
            Console.WriteLine($"The {intern} who had worked {lastMonthWorkHours} hours last month will obtain the bonus payment: {Accountant.AskForBonus(intern, lastMonthWorkHours)}");
            lastMonthWorkHours = 150;
            Console.WriteLine($"The {director} who had worked {lastMonthWorkHours} hours last month will obtain the bonus payment: {Accountant.AskForBonus(director, lastMonthWorkHours)}");
            Console.WriteLine($"The {manager} who had worked {lastMonthWorkHours} hours last month will obtain the bonus payment: {Accountant.AskForBonus(manager, lastMonthWorkHours)}");
            Console.WriteLine($"The {worker} who had worked {lastMonthWorkHours} hours last month will obtain the bonus payment: {Accountant.AskForBonus(worker, lastMonthWorkHours)}");
            Console.WriteLine($"The {intern} who had worked {lastMonthWorkHours} hours last month will obtain the bonus payment: {Accountant.AskForBonus(intern, lastMonthWorkHours)}");
            //Delay
            Console.ReadKey();
        }
    }
}
