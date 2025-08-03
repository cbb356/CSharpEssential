/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
 * Створіть клас CarCollection. Реалізуйте у найпростішому наближенні можливість використання 
 * екземпляра для створення парку машин. Мінімально необхідний інтерфейс взаємодії з екземпляром 
 * повинен включати метод додавання машин з назвою машини і року її випуску, 
 * індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання 
 * для отримання загальної кількості елементів. Створіть спосіб видалення всіх машин автопарку.
 */

namespace CarCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection carsFleet = new CarCollection();

            // Adding some cars
            carsFleet.Add("Mercedes", 2020);
            carsFleet.Add("Toyota", 2019);
            carsFleet.Add("Ford", 2016);
            Console.WriteLine($"There are {carsFleet.Count} cars in the fleet");

            // Showing cars in the fleet
            for (int i = 0; i < carsFleet.Count; i++)
            {
                Console.WriteLine(carsFleet[i].ToString());
            }
            Console.WriteLine();

            // Delete all cars
            carsFleet.Clear();
            Console.WriteLine($"There are {carsFleet.Count} cars in the fleet");

            // Delay.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
