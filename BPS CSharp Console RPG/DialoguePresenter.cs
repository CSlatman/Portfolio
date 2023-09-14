using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPS_CSharp_Console_RPG
{
    public class DialoguePresenter
    {
        public static void DisplayMainMenu()
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Start New Game");
            Console.WriteLine("2. Load Game");
            Console.WriteLine("3. Save Game");
            Console.WriteLine("4. Fight Monster");
            Console.WriteLine("5. Exit");
        }
        public static int GetUserChoice()
        {
            Console.Write("Enter your choice: ");
            return InputHandler.ReadIntInput(1, 5);
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
