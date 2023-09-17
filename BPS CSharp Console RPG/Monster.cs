using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BPS_CSharp_Console_RPG
{
    public class Monster
    {
        /// <summary>
        /// The name of the enemy.
        /// </summary>
        private string _name;
        public string Name { get; set; }

        /// <summary>
        /// The health of the enemy.
        /// </summary>
        private int _health;
        public int Health { get; set; }

        public int Damage { get; set; }

        /// <summary>
        /// Determines whether the enemy is dead or alive.
        /// </summary>
        private int _isDead;
        public bool IsDead { get; set; }

        public void DisplayInfo()
        {
            DialoguePresenter.DisplayMessage($"Monster: {Name}");
            DialoguePresenter.DisplayMessage($"Health: {Health}");
            DialoguePresenter.DisplayMessage($"Damage: {Damage}");
        }
        /// <summary>
        /// This is called when the enemy is hit.
        /// </summary>
        /// <param name="hit_value"> The amount of damage the enemy will take. </param>
        public void TakesDamage(int hit_value)
        {
            Health = Health - hit_value;

            //Check if the enemy is dead.
            if (Health <= 0)
            {
                //The enemy is dead.
                Die();
            }
            //Write that the enemy got hit.
            Console.WriteLine(Name + " was hit for " + hit_value + " damage! He now has " + Health + " remaining!");



        }

        private void Die()
        {
            //Sets the boolean that the enemy has died.
            IsDead = true;
            //Write to the console that you have defeated the enemy.
            Console.WriteLine(Name + " has died!");


        }
    }
}
