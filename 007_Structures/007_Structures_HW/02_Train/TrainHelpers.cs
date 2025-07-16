namespace Train
{
    internal class TrainHelpers
    {
        internal static void ShowTrains(Train[] array)
        {
            Console.WriteLine("The train's schedule");
            foreach (Train train in array)
            {
                Console.WriteLine(train);
            }
        }

        internal static void SortTrains(Train[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minNumber = array[i].Number;
                int minNumberIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].Number < minNumber)
                    {
                        minNumber = array[j].Number;
                        minNumberIndex = j;
                    }
                }

                if (minNumberIndex != i)
                {
                    Train temp = array[i];
                    array[i] = array[minNumberIndex];
                    array[minNumberIndex] = temp;
                }
            }
        }
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

            //Train creation
            return new Train(trainDestination, trainNumber, trainDepartureTime);
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

        internal static Train[] CreateTrainsSchedule(int TrainsNumber)
        {
            Train[] trains = new Train[TrainsNumber];

            Console.WriteLine($"Enter the data for {TrainsNumber} trains");
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Enter data for train {i + 1}:");
                trains[i] = TrainFactory();
            }

            return trains;
        }
    }
}