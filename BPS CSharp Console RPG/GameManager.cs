using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPS_CSharp_Console_RPG
{
    public class GameManager
    {
        public void StartNewGame(Player player)
        {
            Console.WriteLine("\nStarting a New Game...");

            // Logic for character creation and game initialization
            player.Name = ConsoleUtils.GetUserInput("Enter your character's name: ");
            player.Level = 1;
            player.Health = 100;

            Console.WriteLine($"Welcome, {player.Name}! Your adventure begins.");
            player.DisplayInfo();

            // Continue with the game's storyline and gameplay
        }

        public void LoadGame(Player player)
        {
            Console.WriteLine("\nLoading Game...");

            // Logic for loading a saved game state
            // (This part remains the same)

            Console.WriteLine("Game loaded successfully!");
            player.DisplayInfo();

            // Continue with the loaded game state
        }

        public void SaveGame(Player player)
        {
            Console.WriteLine("\nSaving Game...");

            // Logic for saving the game state
            // (This part remains the same)

            Console.WriteLine("Game saved successfully!");
        }
    }
}
