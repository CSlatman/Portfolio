using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

namespace Testproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 2;
            for (int i = 1; i < 100;
                 i = i * 2)
            {
                j = j - 1;
                while (j < 25)
                {
                    // How many times will
                    // the next statement
                    // be executed? 7 times
                    j = j + 5;
                    Console.WriteLine(j);
                }
            }

        }
    }
}