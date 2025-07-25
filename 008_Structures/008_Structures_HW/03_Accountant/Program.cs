namespace Accountant

/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
 * Створіть перелік, який містить посади співробітників як імена констант. 
 * Надайте кожній константі значення, що задає кількість годин, які повинен відпрацювати 
 * співробітник протягом місяця. Створіть клас Accountant 
 * з методом bool AskForBonus (Post worker, int hours), 
 * що відображатиме давати співробітнику премію. 
 * Якщо співробітник відпрацював більше годин на місяць, то йому належить премія.
 */

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accountant.ShowBonus(Post.Director, 180);           
            Accountant.ShowBonus(Post.Worker, 180);           

            //Delay
            Console.ReadKey();
        }
    }
}
