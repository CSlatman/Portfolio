namespace BPS_CSharp_Console_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Monster monster = new Monster("Meowth the talking cat");
            GameManager gameManager = new GameManager();
            Database database = new Database("player.json");

            Console.WriteLine("Welcome to the Console RPG!");

            while (true)
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Start New Game");
                Console.WriteLine("2. Load Game");
                Console.WriteLine("3. Save Game");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = ConsoleUtils.ReadIntInput(1, 4);

                switch (choice)
                {
                    case 1:
                        gameManager.StartNewGame(player);
                        break;
                    case 2:
                        player = database.LoadData<Player>();
                        gameManager.LoadGame(player);
                        break;
                    case 3:
                        database.SaveData(player);
                        gameManager.SaveGame(player);
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        return;
                }
            }
        }
    }
}