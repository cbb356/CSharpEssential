using static System.Net.Mime.MediaTypeNames;

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
        internal static Train TrainFactory()
        {
            string trainDestination;
            int trainNumber;
            TimeOnly trainDepartureTime;

            //Enter the destination for train
            while (true)
            {
                Console.Write("Enter the destination for the train: ");
                trainDestination = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(trainDestination))
                {
                    Console.WriteLine("Enter the non-empty value");
                    continue;
                }
                break;
            }

            //Enter the number for train
            Console.Write("Enter the number for the train: ");
            while (!int.TryParse(Console.ReadLine(), out trainNumber))
            {
                Console.WriteLine("You entered wrong number");
                Console.Write("Enter the number for the train: ");
            }

            //Enter the departure time for train
            Console.Write("Enter the time (HH:MM) of the train departure: ");
            while (!TimeOnly.TryParse(Console.ReadLine(), out trainDepartureTime))
            {
                Console.WriteLine("You entered non-valid time");
                Console.Write("Enter the time (HH:MM) of the train departure: ");
            }

            //Create train
            return new Train(trainDestination, trainNumber, trainDepartureTime);
        }

        internal static void SortArray(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = 0; j < trains.Length; j++)
                {
                    if (trains[i].Number <= trains[j].Number)
                    {
                        Train temp = trains[i];
                        trains[i] = trains[j];
                        trains[j] = temp;
                    }
                }
            }
        }

        internal static void ShowArray(Train[] trains)
        {
            Console.WriteLine("The train's schedule");
            foreach (Train train in trains)
            {
                Console.WriteLine(train);
            }
        }

        internal static void trainWithNumberInfo(Train[] trains)
        {
            //Show the train with entered number
            int trainNumberToFind;
            bool trainFound = false;
            Console.Write("Enter the number of the train for receiving train information: ");
            while (!int.TryParse(Console.ReadLine(), out trainNumberToFind))
            {
                Console.WriteLine("You entered wrong number");
                Console.Write("Enter the number of the train for receiving train information: ");
            }
            foreach (Train train in trains)
            {
                if (train.Number == trainNumberToFind)
                {
                    Console.WriteLine("The train details");
                    Console.WriteLine(train);
                    trainFound = true;
                }
            }
            if (!trainFound)
            {
                Console.WriteLine($"The train with number {trainNumberToFind} has not been found");
            }
        }

        static void Main(string[] args)
        {
            const int TrainsNumber = 2;
            //Create and fill train's array
            Train[] trains = new Train[TrainsNumber];
            Console.WriteLine($"Enter the data for {TrainsNumber} trains");
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Enter data for train {i + 1}:");
                trains[i] = TrainFactory();
            }
            //Sort array
            SortArray(trains);
            //Show array
            Console.WriteLine();
            ShowArray(trains);
            //Show train with entered bumber
            Console.WriteLine();
            trainWithNumberInfo(trains);


            // Delay.
            Console.ReadKey();
        }
    }
}
