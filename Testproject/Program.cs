using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

namespace Testproject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OperatorExamples();


        }

        private static void OperatorExamples()
        {
            // This statement declares a variable and sets it to 3
            int width = 3;

            // The ++ operator increments a variable (adds 1 to it)
            width++;

            // Declare two more int variables to hold numbers and
            // use the + and * operators to add and multiply values
            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            // The next two statements declare string variables
            // and use + to concatenate them (join them together)
            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);
        }
    }
}