using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPS_CSharp_Console_RPG
{
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public void DisplayInfo()
        {
            DialoguePresenter.DisplayMessage($"Name: {Name}");
            DialoguePresenter.DisplayMessage($"Level: {Level}");
            DialoguePresenter.DisplayMessage($"Health: {Health}");
            DialoguePresenter.DisplayMessage($"Damage: {Damage}");
        }


    }
}
