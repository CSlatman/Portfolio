using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPS_VerdiepingSoftwareRPG
{
    public class Monster
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        private List<Monster> monsters;
        public List<Monster> Monsters
        {
            get { return monsters; }
        }
    }
}
