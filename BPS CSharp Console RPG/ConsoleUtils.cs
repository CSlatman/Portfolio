using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPS_CSharp_Console_RPG
{
    public class ConsoleUtils
    {
        public static string GetUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static int ReadIntInput(int minValue, int maxValue)
        {
            int input;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out input) && input >= minValue && input <= maxValue)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine($"Please enter a valid number between {minValue} and {maxValue}.");
                }
            }
        }
    }
}
