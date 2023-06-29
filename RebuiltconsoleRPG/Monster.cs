using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebuiltconsoleRPG
{
    public class Monster
    {

        public string Name { get; set; }
        private int _monsterHealth;
        public int MonsterHealth { get; set; }
        public bool IsDead { get; set; }

        private List<Monster> monsters;
        public List<Monster> Monsters
        {
            get { return monsters; }
        }

        public void AddMonster(Monster monster)
        {
            monsters.Add(monster);
        }
        public Monster(string name)
        {
            MonsterHealth = 50;

            Name = name;
        }


        public void TakesDamage(int hit_value)
        {
            MonsterHealth = MonsterHealth - hit_value;

            //Write that the enemy got hit.
            Console.WriteLine(Name + " was hit for " + hit_value + " damage! He now has " + MonsterHealth + " remaining!");


            //Check if the enemy is dead.
            if (MonsterHealth <= 0)
            {
                //The enemy is dead.
                MonsterDies();
            }
        }

        private void MonsterDies()
        {
            //Write to the console that you have defeated the enemy.
            Console.WriteLine(Name + " has died!");

            //Sets the boolean that the enemy has died.
            IsDead = true;
        }
    }
}
