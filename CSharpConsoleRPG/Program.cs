namespace CSharpConsoleRPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            //This creates and stores the random class as an object.
            Random random = new Random();

            //instantiates the player class as an object.
            Player player = new Player();

            //Asks the player for their name and stores the name inside the object player.
            Console.WriteLine("What's your name?");
            player.PlayerName = Console.ReadLine();

            Console.WriteLine("Welcome " + player.PlayerName + ". We're glad to see you!");

            Enemy firstEnemy = new Enemy("Giant Slime");

            Console.WriteLine(player.PlayerName + " , you have encountered " + firstEnemy.Name + "! What would you like to do?");



            while (!firstEnemy.IsDead && !player.PlayerIsDead)
            {
                Console.WriteLine("1. Single Attack.");
                Console.WriteLine("2. A Three Strike Attack.");
                Console.WriteLine("3. Defend.");
                Console.WriteLine("4. Attempt to run away.");

                int playerChoice = Convert.ToInt32(Console.ReadLine());

                switch (playerChoice)
                {
                    case 1:
                        {
                            Console.WriteLine("You have attacked the slime! How cruel!");
                            firstEnemy.TakesDamage(random.Next(1, 15));
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("You have attacked the slime, three times! How mean!");
                            for (int i = 0; i < 3; i++)
                            {
                                firstEnemy.TakesDamage(random.Next(1, 5));

                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("The slime does nothing. It is worried about you trying to defend.");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("You ran away successfully. Slimes are not known to be fast. Why did you run?");
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("This is not a valid input. The only valid input is an integer that is either 1, 2 or 3.");
                        }

                        break;
                }
                player.PlayerTakesDamage(random.Next(1, 10));
            }

            Console.WriteLine("Game over.");
            Console.ReadLine();
        }
    }
}