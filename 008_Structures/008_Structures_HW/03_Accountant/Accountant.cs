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
    }
}
