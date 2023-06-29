namespace BPS_VerdiepingSoftwareRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Monster> monsters = new List<Monster>();

            // Example monsters
            Monster monster1 = new Monster { Name = "Goblin", Health = 50, AttackPower = 10 };
            Monster monster2 = new Monster { Name = "Skeleton", Health = 40, AttackPower = 15 };
            Monster monster3 = new Monster { Name = "Slime", Health = 30, AttackPower = 10 };
            Monster monster4 = new Monster { Name = "Cat", Health = 60, AttackPower = 15 };

            // Add monsters to the list
            monsters.Add(monster1);
            monsters.Add(monster2);
            monsters.Add(monster3);
            monsters.Add(monster4);

            Random random = new Random();
            int randomIndex = random.Next(0, monsters.Count);
            Monster selectedMonster = monsters[randomIndex];

            Console.WriteLine("A wild " + selectedMonster.Name + " appears!");
            Console.WriteLine("Health: " + selectedMonster.Health);
            Console.WriteLine("Attack Power: " + selectedMonster.AttackPower);
        }
    }
}