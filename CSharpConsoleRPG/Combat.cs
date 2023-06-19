﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleRPG
{
    public class Combat
    {
        public int EncounterType { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enemy"></param>
        /// <param name="random"></param>
        /// <param name="player"></param>
        public Combat(Monster enemy, Random random, Player player) 
        {
            Console.WriteLine(player.PlayerName + " , you have encountered " + enemy.Name + "! What would you like to do?");


            // While the first enemy is NOT dead and while the player is NOT dead, continue this combat.
            while (!enemy.IsDead && !player.PlayerIsDead)
            {
                Console.WriteLine("1. Single Attack.");
                Console.WriteLine("2. A Three Strike Attack.");
                Console.WriteLine("3. Defend.");
                Console.WriteLine("4. Heal youreslf.");
                Console.WriteLine("5. Make a savegame.");
                Console.WriteLine("6. Load a savegame.");

                int playerChoice = Convert.ToInt32(Console.ReadLine());

                switch (playerChoice)
                {
                    case 1:
                        {
                            Console.WriteLine("You have attacked the " + enemy + "! How cruel!");
                            enemy.TakesDamage(random.Next(10, 50));
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("You have attacked the " + enemy + ", three times! How mean!");
                            for (int i = 0; i < 3; i++)
                            {
                                enemy.TakesDamage(random.Next(5, 25));

                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("The " + enemy + " does nothing. It is worried about you trying to defend.");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("You are choosing to heal yourself.");
                            player.Heal(random.Next(5, 20));
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("You are choosing to save your game..");
                            DatabaseJSON.JSONSave();
                            
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("You are choosing to load your game.");
                            DatabaseJSON.JSONLoad();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("This is not a valid input. The only valid input is an integer that is either 1, 2 or 3.");
                        }

                        break;
                }
                player.PlayerTakesDamage(random.Next(1, 10));
            }
        }

    }
}