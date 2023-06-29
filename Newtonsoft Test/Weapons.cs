using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newtonsoft_Test
{
    public class Weapon
    {
        public string Email;

        private string weaponname;
        private int weapondamage;

        public string WeaponName
        {
            get { return weaponname; } 
            set { weaponname = value; }
        }

        public int WeaponDamage
        {
            get { return weapondamage; }
            set { weapondamage = value; }
        }

        public Weapon(string weaponname, int weapondamage)
        {
            
        }
    }
}
