using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPS_CSharp_Console_RPG
{
    public class GameManager
    {
        private List<Monster> monsters;
        private Random random;
        private Database database;

        public GameManager()
        {
            InitializeMonsters();
            random = new Random();
            database = new Database();
        }

        private void InitializeMonsters()
        {
            monsters = new List<Monster>
            {
                new Monster { Name = "Goblin", Health = 30, Damage = 5 },
                new Monster { Name = "Orc", Health = 50, Damage = 8 },
                new Monster { Name = "Dragon", Health = 100, Damage = 15 }
                // Add more monsters as needed
            };
        }

        public void StartNewGame(Player player)
        {
            DialoguePresenter.DisplayMessage("\nStarting a New Game...");

            player.Name = InputHandler.GetUserInput("Enter your character's name: ");
            player.Level = 1;
            player.Health = 100;
            player.Damage = 10;

            DialoguePresenter.DisplayMessage($"Welcome, {player.Name}! Your adventure begins.");
            player.DisplayInfo();
        }

        public void LoadGame(Player player)
        {
            DialoguePresenter.DisplayMessage("\nLoading Game...");

            if (File.Exists("player.json"))
            {
                player = database.LoadData<Player>();
                DialoguePresenter.DisplayMessage("Game loaded successfully!");
                player.DisplayInfo();
            }
            else
            {
                DialoguePresenter.DisplayMessage("No saved game found.");
            }
        }

        public void SaveGame(Player player)
        {
            DialoguePresenter.DisplayMessage("\nSaving Game...");

            database.SaveData(player);
            DialoguePresenter.DisplayMessage("Game saved successfully!");
        }

        public Monster GetRandomMonster()
        {
            return monsters[random.Next(monsters.Count)];
        }
    }
}
