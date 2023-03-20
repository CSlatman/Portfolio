using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1HerovMonster
{
    internal class Monster
    {
        private Random randomizer = new Random();

        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }

        public Monster(string name, int attack)
        {
            Name = name;
            Attack = attack;
            Health = 100;



        }

    }
}
