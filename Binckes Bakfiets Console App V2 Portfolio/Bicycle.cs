using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binckes_Bakfiets_Console_App_V2_Portfolio
{
    public class Bicycle : ShopItems
    {
        // Misschien handig om een Enum te maken, dan kan daar een aparte class voor gemaakt worden

        // enum / array for bibycle types

        public int BiccyelType { get; set; }

        /// <summary>
        /// This is the field for
        /// </summary>
        public string BicycleGender { get; set; }
        public int BicycleSize { get; set; }

        public Bicycle(string BicycleGender)
        {

        }
        public Bicycle(string BicycleType, string BicycleGender, int BicycleSize)
        {

        }
        
    }


}
