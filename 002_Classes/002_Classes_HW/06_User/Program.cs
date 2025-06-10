namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("user", "John", "Doe", 25);
            user.ShowUserInfo();
        }
    }
}
