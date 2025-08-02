/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
 * Створіть  клас  MyClass  <T>,  що  містить  статичний  фабричний  метод  -  T  FactoryMethod  (),  
 * який  буде породжувати екземпляри типу, зазначеного в якості параметра типу 
 * (покажчика місця заповнення типом - Т). 
 */

namespace Bonus_Factorymethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Int instance: {MyClass<int>.FactoryMethod()}");
            Console.WriteLine($"Double instance: {MyClass<double>.FactoryMethod()}");
            Console.WriteLine($"Char instance: {MyClass<char>.FactoryMethod()}");
            Console.WriteLine($"ClassExample instance: {MyClass<ClassExample>.FactoryMethod()}");

            // Delay.
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
