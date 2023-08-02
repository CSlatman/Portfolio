using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMonsterSerialization
{
    public class Monster
    {
        private string name;
        public string Name 
        {
            set { name = value; }
            get { return name; } 
        }

        private int health;
        public int Health
        {
            set { health = value; }
            get { return health; }

        }

        private int attackPower;
        public int AttackPower
        {
            set { attackPower = value; }
            get { return attackPower; }

        }

        public Monster(string name, int health, int attackPower)
        {
            this.name = name;
            this.health = health;
            this.attackPower = attackPower;
        }


        public static void MakenewMonster()
        {
            Console.WriteLine("What's the name of the monster?");
            string name = Console.ReadLine();
            Console.WriteLine("What's the health of the monster?");
            int health = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's the attack power of the monster?");
            int attackpower = Convert.ToInt32(Console.ReadLine());

            Monster newmonster = new Monster(name, health, attackpower);


            Console.WriteLine(newmonster.Name);
            Console.WriteLine(newmonster.Health);
            Console.WriteLine(newmonster.AttackPower);

        }

        public static void ReturnMonster()
        {
            // Choosing a specific property to return
            Console.WriteLine("Either choose: Name, Health, or AttackPower");
            string chosenProperty = Console.ReadLine();

            foreach (var monster in monsters)
            {
                switch (chosenProperty)
                {
                    case "Name":
                        Console.WriteLine("Monster Name: " + monster.Name);
                        break;
                    case "Health":
                        Console.WriteLine("Monster Health: " + monster.Health);
                        break;
                    case "AttackPower":
                        Console.WriteLine("Monster Attack Power: " + monster.AttackPower);
                        break;
                    default:
                        Console.WriteLine("Invalid property choice.");
                        break;
                }
            }
        }

    }
}
