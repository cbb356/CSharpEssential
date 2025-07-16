namespace Train
{
    internal class TrainsSchedule
    {
        private Train[] trains;

        public TrainsSchedule (int TrainsNumber)
        {
            trains = new Train[TrainsNumber];
        }

        internal Train TrainFactory()
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

        internal void InputTrainsSchedule()
        {
            Console.WriteLine($"Enter the data for {trains.Length} trains");
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Enter data for train {i + 1}:");
                trains[i] = TrainFactory();
            }
        }

        internal void GenerateTrainsSchedule()
        {
            Random random = new Random();

            for (int i = 0; i < trains.Length; i++)
            {
                string destination = $"Destination_{i + 1}";
                int number = random.Next(1, 100);
                int hour = random.Next(0, 24); // from 0 to 23
                int minute = random.Next(0, 60); // from 0 to 59
                TimeOnly departureTime = new TimeOnly(hour, minute);
                trains[i] = new Train(destination, number, departureTime);
            }
        }

        internal void SortTrains()
        {
            for (int i = 0; i < trains.Length - 1; i++)
            {
                int minNumber = trains[i].Number;
                int minNumberIndex = i;

                for (int j = i + 1; j < trains.Length; j++)
                {
                    if (trains[j].Number < minNumber)
                    {
                        minNumber = trains[j].Number;
                        minNumberIndex = j;
                    }
                }

                if (minNumberIndex != i)
                {
                    Train temp = trains[i];
                    trains[i] = trains[minNumberIndex];
                    trains[minNumberIndex] = temp;
                }
            }
        }

        internal void ShowTrains()
        {
            Console.WriteLine("The train's schedule");
            foreach (Train train in trains)
            {
                Console.WriteLine(train);
            }
        }

        internal void ShowTrainByNumber()
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
    }
}