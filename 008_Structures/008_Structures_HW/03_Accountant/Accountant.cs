namespace Accountant
{
    public enum Post
    {
        Director = 170,
        Manager = 180,
        Worker = 190,
        Intern = 200
    }

    internal static class Accountant
    {
        public static bool AskForBonus(Post worker, int hours)
        {
            return (int)worker < hours;
        }

        public static void ShowBonus(Post worker, int hours)
        {
            Console.Write($"The {worker} who had worked {hours} hours last month ");
            if (AskForBonus(worker, hours))
                Console.WriteLine($"will obtain the bonus payment");
            else
                Console.WriteLine($"won't obtain the bonus payment");
        }
    }
}
