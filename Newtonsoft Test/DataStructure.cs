using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newtonsoft_Test
{
    public class DataStructure
    {
        public string Name { get; set; }
        public List<int> Identifiers { get; set; }

        public void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Identifiers: " + string.Join<int>(",", Identifiers));
            Console.WriteLine();
            Console.WriteLine();
        }


        /* To use in main
                     var data = new DataStructure
            {
                Name = "Henry",
                Identifiers = new List<int> { 1, 2, 3, 4 }
            };

            Console.WriteLine("Object before serialization:");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            data.Print();

            JsonDatabase.Serialize(data);

            const string FileNameWeapons = @"C:\JSON\Weapons.json";
            var deserialized = JsonDatabase.Deserialize(FileNameWeapons);

            Console.WriteLine("Deserialized (json) string:");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine(deserialized);
         */
    }
}
