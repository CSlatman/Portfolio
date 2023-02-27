using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoeroeCalcPortfolio
{
    public class calculator
    {

        public void choice()
        {
            Console.WriteLine("Choose 1 for addition.");
            Console.WriteLine("Choose 2 for subtraction.");
            Console.WriteLine("Choose 3 for multiplication.");
            Console.WriteLine("Choose 4 for division.");
            //Console.WriteLine("Choose 5 for the quadrification");
            //Console.WriteLine("Choose 6 to find the square root of a number");
            Console.WriteLine("After entering a number such as 1, 2, 3 or 4. Press Enter.");


            string userChoice = Console.ReadLine();
            bool boolUserCHoice = string.IsNullOrEmpty(userChoice);
            if (boolUserCHoice == true)
            {
                Console.WriteLine("The user didn't input anything.");
            }
            //If the user tries to enter nothing, then the parsedChoice becomes 0.
            int parsedChoice;
            int.TryParse(userChoice, out parsedChoice);

            Console.WriteLine("You have chosen " + parsedChoice);

            Console.WriteLine("Enter the first input and then press Enter.");
            string UserInput1 = Console.ReadLine();
            int parsedInput1;
            int.TryParse(UserInput1, out parsedInput1);

            Console.WriteLine("Enter the second input and then press Enter.");
            string UserInput2 = Console.ReadLine();
            int parsedInput2;
            int.TryParse(UserInput2, out parsedInput2);
            int result = 0;

            switch (parsedChoice)
            {
                case 1:
                    {
                        result = Addition(parsedInput1, parsedInput2);

                        if (result < 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Hello. The result is negative. THe result was: " + result);
                        }
                        else
                        {
                            Console.WriteLine("Hello. The result is positive and above zero. The result was: " + result);
                        }
                        break;
                    }
                case 2:
                    // In this case it shows me the else as well as the first if.
                    {
                        result = Subtraction(parsedInput1, parsedInput2);
                        
                        
                        if (result < 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("This is the if. Hello. The result is negative. THe result was: " + result);
                        }
                        else
                        {
                            Console.WriteLine("This is the else. The result is positive and above zero. The result was: " + result);
                        }
                        

                        Console.ResetColor();
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(parsedInput1, parsedInput2);

                        if (result < 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Hello. The result is negative. THe result was: " + result);
                        }
                        else
                        {
                            Console.WriteLine("Hello. The result is positive and above zero. The result was: " + result);
                        }
                        break;
                    }
                case 4:
                    {
                        result = Division(parsedInput1, parsedInput2);

                        if (result < 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Hello. The result is negative. THe result was: " + result);
                        }
                        else
                        {
                            Console.WriteLine("Hello. The result is positive and above zero. The result was: " + result);
                        }
                        break;
                    }
                default:
                    {
                        //parsedchoice only registers here.
                        Console.WriteLine("You have chosen... poorly.");
                        break;
                    }

            }

            // Let's skip the quadrification and the square root for now.

        }
        //Addition  
        public int Addition(int parsedInput1, int parsedInput2)
        {
            int result = parsedInput1 + parsedInput2;
            return result;
        }
        public int Subtraction(int parsedInput1, int parsedInput2)
        {
            int result = parsedInput1 - parsedInput2;
            return result;
        }
        public int Multiplication(int parsedInput1, int parsedInput2)
        {
            int result = parsedInput1 * parsedInput2;
            return result;
        }
        public int Division(int parsedInput1, int parsedInput2)
        {
            int result = parsedInput1 / parsedInput2;
            return result;
        }
    }
}
