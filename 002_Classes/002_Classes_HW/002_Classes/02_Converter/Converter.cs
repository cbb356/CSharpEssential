namespace Classes
{
    internal class Converter
    {
        private double usd;
        private double eur;
        private double gbp;
        public Converter(double usd, double eur, double gbp)
        {
            this.usd = usd;
            this.eur = eur; 
            this.gbp = gbp;
        }

        public double ConvertUsdUah(double sum)
        { 
            return sum * usd;
        }

        public double ConvertEurUah(double sum)
        {
            return sum * eur;
        }

        public double ConvertGbpUah(double sum)
        {
            return sum * gbp;
        }
        public double ConvertUahUsd(double sum)
        {
            return sum / usd;
        }

        public double ConvertUahEur(double sum)
        {
            return sum / eur;
        }

        public double ConvertUahGbp(double sum)
        {
            return sum / gbp;
        }
    }
}
