/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
 * Створіть узагальнений клас MyClass, що містить статичний фабричний метод – T FacrotyMethod(), 
 * який породжуватиме екземпляри типу, вказаного як параметр типу (покажчика місця заповнення типом – Т). 
 * Яким має бути тип, що підставляється під T?
 */

namespace MyClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Int '{MyClass<int>.FactoryMethod()}' created");
            Console.WriteLine($"Double '{MyClass<double>.FactoryMethod()}' created");
            Console.WriteLine($"Char '{MyClass<char>.FactoryMethod()}' created");
            Console.WriteLine($"String '{MyClass<char>.FactoryMethod()}' created");
            Console.WriteLine($"ParameterlessClass '{MyClass<ParameterlessClass>.FactoryMethod()}' created");

            // This would cause a compile-time error because type must be a non-abstract with a public parameterless constructor 
            //Console.WriteLine($"ParameterizedConstructorClass {MyClass<ParameterizedConstructorClass>.FactoryMethod()} created");
            //Console.WriteLine($"AbstractClass {MyClass<AbstractClass>.FactoryMethod()} created");

            // Delay.
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
