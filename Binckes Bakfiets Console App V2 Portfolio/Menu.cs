using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Binckes_Bakfiets_Console_App_V2_Portfolio
{
    public class Menu
    {
        // The first implementation of a menu for the user.
        public void choice()
        {
            // This sets hte MenuChoice to be 0, in case the user doesn't want to enter the menu.
            int MenuChoice = 0;
            Console.WriteLine("Welcome to the Binckes Bakfiets application.");
            Console.WriteLine("Do you wish to enter the menu, then press 1.");

            string input = Console.ReadLine();
            Int32.TryParse(input, out MenuChoice);

            while (MenuChoice == 1)
            {
                //Welcomes the user to the BB Menu.
                Console.WriteLine("This is the Binckes Bakfiets Menu!");
                

                Console.WriteLine();

                //Informs the user about the sequence in which the program asks questions.
                Console.WriteLine("This program is sequenced in a way that you will choose which bicycle you would like first.");
                Console.WriteLine("Second, you will select the relevant accessories you deem appropriate.");
                Console.WriteLine("Third and last, we'll ask you how long you want to rent it,");
                Console.WriteLine(" whereupon you can see the total and confirm or decline the transaction.");



                // This increases the before entered MenuChoice by 1, which then makes the while loop false.
                MenuChoice++;
                break;
                



            }

        }
    }
}
