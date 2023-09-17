using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPS_CSharp_Console_RPG
{
    public class Combat
    {
        public static void Fight(Player player, Monster enemy)
        {
            // Combat logic here (e.g., damage calculation)

            // Example: Display combat results
            DialoguePresenter.DisplayMessage($"You dealt {player.Damage} damage to the {enemy.Name}.");
            DialoguePresenter.DisplayMessage($"{enemy.Name} dealt {enemy.Damage} damage to you.");

            // Example: Determine battle outcome (victory, defeat)
            if (player.Health <= 0)
            {
                DialoguePresenter.DisplayMessage("Game Over! You were defeated by the monster.");
            }
            else
            {
                DialoguePresenter.DisplayMessage($"You defeated the {enemy.Name}!");
            }
        }
    }
}
