namespace Train
{
    internal struct Train
    {
        public string Destination { get;}
        public int Number { get;}
        public TimeOnly DepartureTime { get;}

        public Train(string destination, int number, TimeOnly departureTime)
        {
            Destination = destination;
            Number = number;
            DepartureTime = departureTime;
        }

        public override string ToString()
        {
            return ($"Destination: {Destination}\tNumber: {Number}\tDeparture time: {DepartureTime:HH:mm}");
        }
    }
}
