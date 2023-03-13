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
        public bool choice()
        {

            /// This runs this loop while it's true and ít's true by default.
            /// Might need to create an exit
            do
            {
                //Welcomes the user to the BB app.
                Console.WriteLine("Welcome to the Binckes Bakfiets application.");

                Console.WriteLine();

                //Informs the user about the sequence in which the program asks questions.
                Console.WriteLine("This program is sequenced in a way that you will which bicycle you would like first.");
                Console.WriteLine("Second, you will select the relevant accessories you deem appropriate.");
                Console.WriteLine("Third and last, we'll ask you how long you want to rent it,");
                Console.WriteLine(" whereupon you can see the total and confirm or decline the transaction.");


                /*
                // Choose a bicycle type to rent
                Console.WriteLine("There are four different types of bicycle.");
                Console.WriteLine("Press 0 for a mountain bike.");
                Console.WriteLine("Press 1 for a racing bike.");
                Console.WriteLine("Press 2 for a city bike.");
                Console.WriteLine("Press 3 for a cargo bike.");
                
                var bicycleType = Console.ReadLine();
                


                Bicycle UserBicycle = new Bicycle(bicycleType);
                Console.WriteLine("You've selected a " + UserBicycle.BicycleTypes);
                */

                // Choose the gender of your bicycle.
                Console.WriteLine("Now we would like you to select a gentleman's bike or a lady's bike.");
                Console.WriteLine("Please type male or female.");
                string bicycleGender = Console.ReadLine();

                Bicycle UserBicycle = new Bicycle(bicycleGender);
                Console.WriteLine("You've selected a " + UserBicycle.BicycleGender + " bike.");

                //public Bicycle(string BicycleType, string BicycleGender, int BicycleSize
                // Choose the different accessories to accompany it

                // Choose for how long

                // Checkout




            }
            while (true);

        }
    }
}
