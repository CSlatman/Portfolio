using System.Numerics;

namespace GoeroeCalcPortfolio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to do today?");

            calculator c = new calculator();
            c.choice();


            /* 
            Console.WriteLine("Would you like to find the square root of a number?");
            try
            {
                // If the user doesn't input anything, auto input becomes 0 due to the string being empty.
                // 
                string stringUserSquareRoot = Console.ReadLine();
                double doubleUserSquareRoot;
                double.TryParse(stringUserSquareRoot, out doubleUserSquareRoot);
                Console.WriteLine(Math.Sqrt(doubleUserSquareRoot));
            }
            catch (Exception a)
            {
                Console.WriteLine("You seem to have forgotten to put in a valid number, this results in this error: " + a.Message);
                throw;x
            }
            
            */

        }
    }
}