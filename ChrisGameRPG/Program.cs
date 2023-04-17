namespace ChrisGameRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine("What's your name?");

            player.PlayerName = Console.ReadLine();

            Console.WriteLine("So your name is: " + player.PlayerName + " ?");

        }
    }
}