using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RebuiltconsoleRPG
{
    public class Combat
    {
        public Combat(Random random)
        {
            int playerChoice = Convert.ToInt32(Console.ReadLine());

            switch (playerChoice)
            {
                case 1:
                    {
                        Console.WriteLine(Dialogue.attack);

                    }
                    break;

                default:
                    {
                        Console.WriteLine("This is not a valid input. The only valid input is an integer that is either 1, 2 or 3.");
                    }

                    break;
            }
            
        }
    }
}
