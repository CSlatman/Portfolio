using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binckes_Bakfiets_Console_App_V2_Portfolio
{
    public class Bicycle : ShopItems
    {
        /// <summary>
        /// Misschien handig om een Enum te maken, dan kan daar een aparte class voor gemaakt worden
        /// </summary>
        public string[] bicycleTypes = new string[4] { "Mountain bike", "Racing bike", "City bike", "Cargo bike" };
        public string BicycleGender { get; set; }
        public int BicycleSize { get; set; }

        public Bicycle(string bicycleType, string BicycleGender, string size)
        {

        }
        
    }


}
