namespace Classes
{
    internal class Converter
    {
        public double Usd { get; set; }
        public double Eur { get; set; }
        public double Gbp { get; set; }

        public Converter(double usd, double eur, double gbp)
        {
            Usd = usd;
            Eur = eur; 
            Gbp = gbp;
        }

        public double ConvertUsdUah(double sum)
        { 
            return sum * Usd;
        }

        public double ConvertEurUah(double sum)
        {
            return sum * Eur;
        }

        public double ConvertGbpUah(double sum)
        {
            return sum * Gbp;
        }
        public double ConvertUahUsd(double sum)
        {
            return sum / Usd;
        }

        public double ConvertUahEur(double sum)
        {
            return sum / Eur;
        }

        public double ConvertUahGbp(double sum)
        {
            return sum / Gbp;
        }
    }
}
