namespace ConsoleApp1_Training___List___PrijzenToevoegen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> prijzen = new List<double>() { 1, 1.50, 3, 5.60 };
            double totaalPrijs = 0.0;

            for (int i = 0; i < prijzen.Count; i++)
            {
                totaalPrijs += prijzen[i];
            }

            Console.Out.WriteLine("De totaalprijs is " + totaalPrijs.ToString("C"));


            List<double> prijsjes = new List<double>();
            prijsjes.Add(10);
            prijsjes.Add(12);
            prijsjes.Add(13);
            prijsjes.Add(15.3);

            double totaalPrijsjes = 0.0;
            // Hier moet je nog een aantal prijzen (doubles) aan de List toevoegen. 

            for (int i = 0; i < prijsjes.Count; i++)
            {
                totaalPrijsjes = totaalPrijsjes + prijsjes[i];
            }

            Console.Out.WriteLine("De totaalprijs is " + totaalPrijsjes.ToString("C"));

        }
    }
}