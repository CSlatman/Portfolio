using System.Diagnostics.Tracing;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

namespace Testproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area = 0;
            int height = 0;
            int width = 2;

            while (area < 50)
            {
                height++;
                area = width * height;
                Console.WriteLine("while area is " + area);
            }

            do 
            {
                width--;
                area = width * height;
                Console.WriteLine("Do while area is " + area);
            } while (area > 50);

        }
    }
}