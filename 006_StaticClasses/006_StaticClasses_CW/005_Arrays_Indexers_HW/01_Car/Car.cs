namespace Car
{
    internal class Car
    {
        Radio radio = new Radio();

        public void RadioOn()
        {
            radio.IsActive = true;
            Console.WriteLine("The radio is ON");
        }

        public void RadioOff()
        {
            radio.IsActive = false;
            Console.WriteLine("The radio is OFF");
        }

        private class Radio
        {
            public bool IsActive { get; set; }
        }


    }
}
