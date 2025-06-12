namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("user_jdoe", "John", "Doe", 25);
            user.ShowUserInfo();

            //Delay
            Console.ReadKey();
        }
    }
}
