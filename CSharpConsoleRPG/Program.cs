﻿using System.Text.Json;
using System.Text.Json.Serialization;

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
            try
            {
                //The ! removes the possible error message, but not the error. Just done as a test for both the ! and the error.
                player.PlayerName = Console.ReadLine()!;
            }
            catch (Exception a)
            {
                //Never gets used at this stage.
                Console.WriteLine("You forgot to write a name, this results in this error: " + a.Message);
                throw;
            }
            

            //Welcoming the playre and using their name.
            Console.WriteLine("Welcome " + player.PlayerName + ". We're glad to see you!");

            //the random and player have already been assigned to variables, this assigns the enemy name to the enem yvariable.
            Monster enemy = new Monster("Enemy Dave");

            //Starts the first battle encounter
            Combat firstEncounter = new Combat(enemy, random, player);

            Monster enemy2 = new Monster("Meowth the talking cat");

            //Starts the second battle encounter
            Combat secondEncounter = new Combat(enemy2, random, player);


            Console.WriteLine("Game over.");
            Console.ReadLine();
        }
    }
}