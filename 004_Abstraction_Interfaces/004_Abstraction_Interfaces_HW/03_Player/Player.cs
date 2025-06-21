namespace Player
{
    internal interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    internal interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }

    internal class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("The player is playing");
        }

        public void Record()
        {
            Console.WriteLine("The player is recording");
        }

        public void Pause()
        {
            Console.WriteLine("The player is paused");
        }

        public void Stop()
        {
            Console.WriteLine("The player is stopped");
        }
    }
}
