namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(41.5, 47.1, 55.9);
            double cur = 100, uah = 1000;
            Console.WriteLine($"{cur} USD = {converter.ConvertUsdUah(cur):F2} UAH");
            Console.WriteLine($"{cur} EUR = {converter.ConvertEurUah(cur):F2} UAH");
            Console.WriteLine($"{cur} GBP = {converter.ConvertGbpUah(cur):F2} UAH");
            Console.WriteLine($"{uah} UAH = {converter.ConvertUahUsd(uah):F2} USD");
            Console.WriteLine($"{uah} UAH = {converter.ConvertUahEur(uah):F2} EUR");
            Console.WriteLine($"{uah} UAH = {converter.ConvertUahGbp(uah):F2} GBP");
        }
    }
}
