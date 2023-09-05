using System.Diagnostics.Tracing;

namespace Testproject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Array tests
            double[] getallen = new double[10];

            getallen[0] = 2.5;
            getallen[1] = 20;
            getallen[2] = 1000;
            getallen[3] = 1000.50;
            Console.WriteLine("Getal nummer 1 = " + getallen[0]);
            Console.WriteLine("Getal nummer 2 = " + getallen[1]);
            Console.WriteLine("Getal nummer 3 = " + getallen[2]);
            Console.WriteLine("Getal nummer 4 = " + getallen[3]);


            Console.WriteLine("break break break");

            int[] getallen2 = new int[10];
            for (int i = 0; i < getallen2.Length; i++)
            {
                Console.WriteLine(getallen2[i] = (i+1) * 5);
            }

            Console.WriteLine("break for List");
            // List tests
            List<int> getallenlist = new List<int>();
            for (int i = 0; i <10; i++)
            {
                getallenlist.Add(10 * 10);
            }

            Console.WriteLine(getallenlist.Count);

            List<string> words = new List<string>();

            words.Add("Hallo");
            words.Add("allemaal!");
            words.Add("Hoe");
            words.Add("gaat");
            words.Add("het?");

            string s;

            // s = words.ElementAt(0) + " " + words[1];

            // Console.WriteLine(s);

            // nog een optie
            List<string> woordjes = new List<string>() { "Hallo", "allemaal!" };

            foreach (var word in words)
            {
                s = word + " ";
                Console.WriteLine(s);
            }
            

        }
    }
}