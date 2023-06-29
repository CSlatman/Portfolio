using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Newtonsoft_Test
{
    public class JsonDatabase
    {
        /// <summary>
        /// These are the properties that show where to save the Folder and the file name of weapons.
        /// </summary>
        public const string Folder = @"C:\JSON\";
        public const string FileNameWeapons= @"C:\JSON\Weapons.json";

        public static void Serialize(object obj)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(FileNameWeapons))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, obj);
            }
        }

        public static object Deserialize(string path)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamReader(path))
            using (var reader = new JsonTextReader(sw))
            {
                return serializer.Deserialize(reader);
            }
        }

    }
}
