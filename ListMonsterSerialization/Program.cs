using CSharpConsoleRPG;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ListMonsterSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseJSON jsonManager = new DatabaseJSON();
            // List<Monster> monsters = jsonManager.LoadInMonsters();

            var random = new Random();


            List<Monster> monsters = new List<Monster>
                (
                new Monster("Goblin", 50, 10),
                new Monster("Orc", 100, 15),
                new Monster("Dragon", 500, 100)


                );



            
        }
    }
}