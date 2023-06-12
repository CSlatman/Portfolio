using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDatabaseTest
{
    public class JsonManager
    {
        public const string Folder = @"C:\temp\";
        public const string BestandsnaamStudenten = "Studenten.json";
        public const string BestandsnaamKlassen = "Klassen.json";

        internal List<Klas> InladenKlassen()
        {
            List<Klas> klassen = new List<Klas>();
            if (CheckKlassenFile())
            {
                using (StreamReader file = File.OpenText(Folder + BestandsnaamKlassen))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    klassen = (List<Klas>)serializer.Deserialize(file, typeof(List<Klas>));
                }
            }
            return klassen;
        }

        internal void OpslaanKlassen(List<Klas> klassen)
        {
            using (StreamWriter file = File.CreateText(Folder + BestandsnaamKlassen)) 
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, klassen);
            }
        }

        internal List<Student> InladenStudenten()
        {
            List<Student> students = new List<Student>();
            if (CheckStudentFile())
            {
                using (StreamReader file = File.OpenText(Folder + BestandsnaamStudenten))
                {
                    JsonSerializer serializer = new JsonSerializer();

                }
            }
        }
    }
}
