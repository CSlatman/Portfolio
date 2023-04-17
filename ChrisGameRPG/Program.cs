using System;

namespace ChrisGameRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This creates and stores the random class as an object.
            Random random = new Random();

            Player player = new Player();
            Console.WriteLine("What's your name?");

            player.PlayerName = Console.ReadLine();

            Console.WriteLine("So your name is: " + player.PlayerName + "? That's a lovely name!");

            //Welcoming the playre and using their name.
            Console.WriteLine("Welcome " + player.PlayerName + ". We're glad to see you!");

            //the random and player have already been assigned to variables, this assigns the enemy name to the enem yvariable.
            Enemy enemy = new Enemy("Enemy Dave");

            //Starts the first battle encounter
            Encounter firstEncounter = new Encounter(enemy, random, player);


            Console.WriteLine("Game over.");
            Console.ReadLine();
        }
    }
}