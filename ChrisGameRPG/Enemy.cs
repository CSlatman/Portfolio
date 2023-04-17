using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisGameRPG
{
    public class Enemy
    {
        /// <summary>
        /// The name of the enemy.
        /// </summary>
        private string _enemyName;
        public string EnemyName
        {
            get { return _enemyName; }
            set { _enemyName = value; }
        }

        /// <summary>
        /// The health of the enemy.
        /// </summary>
        private int _enemyHealth;
        public int EnemyHealth { get; set; }

        /// <summary>
        /// Determines whether the enemy is dead or alive.
        /// </summary>
        public bool IsDead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="EnemyName"></param>
        public Enemy(string EnemyName)
        {
            EnemyHealth = 100;

            EnemyName = _enemyName;
        }
        /// <summary>
        /// This is called when the enemy is hit.
        /// </summary>
        /// <param name="hit_value"> The amount of damage the enemy will take. </param>
        public void TakesDamage(int hit_value)
        {
            EnemyHealth = EnemyHealth - hit_value;

            //Write that the enemy got hit.
            Console.WriteLine(Name + " was hit for " + hit_value + " damage! He now has " + EnemyHealth + " remaining!");


            //Check if the enemy is dead.
            if (EnemyHealth <= 0)
            {
                //The enemy is dead.
                Die();
            }
        }

        private void Die()
        {
            //Write to the console that you have defeated the enemy.
            Console.WriteLine(Name + " has died!");

            //Sets the boolean that the enemy has died.
            IsDead = true;
        }
    }
}
