using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpConsoleRPG
{
    public class DatabaseJSON
    {
        static void JSONSave()
        {
            Player player = new Player();


            var options = new JsonSerializerOptions { WriteIndented = true };

            string json = JsonSerializer.Serialize(player);
            string fileName = "player.json";
            File.WriteAllText(fileName, json);

        }

        static void JSONLoad()
        {
            string fileName = "player.json";
            string jsonString = File.ReadAllText(fileName);
            Player player = JsonSerializer.Deserialize<Player>(jsonString);


            Console.WriteLine($"Name: {player.PlayerName}");
        }
    }
}
