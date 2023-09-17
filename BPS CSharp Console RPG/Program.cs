namespace BPS_CSharp_Console_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            GameManager gameManager = new GameManager();

            DialoguePresenter.DisplayMessage("Welcome to the Console RPG!");

            while (true)
            {
                DialoguePresenter.DisplayMainMenu();
                int choice = DialoguePresenter.GetUserChoice();

                switch (choice)
                {
                    case 1:
                        gameManager.StartNewGame(player);
                        break;
                    case 2:
                        gameManager.LoadGame(player);
                        break;
                    case 3:
                        gameManager.SaveGame(player);
                        break;
                    case 4:
                        Combat.Fight(player, gameManager.GetRandomMonster());
                        break;
                    case 5:
                        DialoguePresenter.DisplayMessage("Goodbye!");
                        return;
                }
            }
        }
    }
}