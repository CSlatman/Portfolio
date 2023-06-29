namespace RebuiltconsoleRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            JsonManager jsonManager = new JsonManager();
            List<Monster> monsters = new List<Monster>();
            monsters = jsonManager.LoadMonsters();
            //Monster monsterGroup = new monsters[0];



            Monster monsterGroup = new Monster("Meow");
            for (int i = 0; i < 3; i++)
            {
                Monster newMonster = MakeNewMonster();
                monsterGroup.AddMonster(newMonster);

                jsonManager.SaveMonsters(monsters);
            }
            Console.ReadKey();


            
        }

        public static Monster MakeNewMonster()
        {
            Monster newMonster = null;

            Console.WriteLine("What's the name of the monster?");
            string monstername = Console.ReadLine();
            
            newMonster= new Monster(monstername);

            return newMonster;
        }
    }
}