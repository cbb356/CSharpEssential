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
    
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TrainsNumber = 8;
            //Create object with train's array
            TrainsSchedule trainsSchedule = new TrainsSchedule(TrainsNumber);
            //Fill array with trains entered by user
            trainsSchedule.InputTrainsSchedule();
            //Fill array with random trains
            //trainsSchedule.GenerateTrainsSchedule();
            //Sort array
            trainsSchedule.SortTrains();
            //Show array
            Console.WriteLine();
            trainsSchedule.ShowTrains();
            //Show train with entered bumber
            Console.WriteLine();
            trainsSchedule.ShowTrainByNumber();

            // Delay.
            Console.ReadKey();
        }
    }
}
