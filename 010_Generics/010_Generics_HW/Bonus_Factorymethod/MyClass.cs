namespace Bonus_Factorymethod
{
    internal class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
}
