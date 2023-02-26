using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleRPG
{
    internal class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession() 
        {
            CurrentPlayer = new Player();
            CurrentPlayer.PlayerName = "Christiaan";
            CurrentPlayer.PlayerHealth = 100;
            CurrentPlayer.PlayerLevel = 1;
            CurrentPlayer.PlayerExperience = 1;
            CurrentPlayer.PlayerGold = 0;

            CurrentLocation = new Location();
            CurrentLocation.LocationName = "Home";
            CurrentLocation.XCoordinate= 0;
            CurrentLocation.YCoordinate= 0;
            CurrentLocation.LocationDescription = "Description";
        }
    }
}
