namespace Classes
{
    internal class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private readonly DateTime registeredAt;

        public User (string login, string firstName, string lastName, int age)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            registeredAt = DateTime.Now;
        }

        public void ShowUserInfo()
        {
            Console.WriteLine($"User info with login {login}: {firstName} {lastName}, {age} years old, registered at {registeredAt}");
        }
    }
}
