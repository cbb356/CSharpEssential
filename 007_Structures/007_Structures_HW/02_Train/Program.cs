namespace Train
{
    /*
     * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Потрібно: Описати структуру з ім'ям Train, що містить такі поля: назву пункту призначення, 
     * номер поїзда, час відправлення. Написати програму, яка виконує такі дії: введення 
     * з клавіатури даних до масиву, що складається з восьми елементів типу Train 
     * (записи мають бути впорядковані за номерами поїздів); виведення на екран інформації про поїзд, 
     * номер якого введено з клавіатури (якщо таких поїздів немає, вивести відповідне повідомлення). 
     */
    
    internal class Program : TrainHelpers
    {
        static void Main(string[] args)
        {
            const int TrainsNumber = 8;
            //Create and fill train's array
            Train[] trains = CreateTrainsSchedule(TrainsNumber);
            //Sort array
            SortTrains(trains);
            //Show array
            Console.WriteLine();
            ShowTrains(trains);
            //Show train with entered bumber
            Console.WriteLine();
            trainWithNumberInfo(trains);


            // Delay.
            Console.ReadKey();
        }
    }
}
