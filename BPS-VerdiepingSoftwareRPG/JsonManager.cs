using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BPS_VerdiepingSoftwareRPG
{
    public class JsonManager
    {        
        /// <summary>
        /// These are the properties that show where to save the Folder and the file name of the player.
        /// </summary>
        public const string Folder = @"C:\JSON\";
        public const string FilenameMonster = "Monster.json";

        public static string Serialize<T>(T data)
        {
            return JsonConvert.SerializeObject(data);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }


        public List<Monster> SaveMonster()
        {
            List<Monster> monsters = new List<Monster>();
            if (CheckMonsterFile())
            {
                using (StreamReader file = File.OpenText(Folder + FilenameMonster))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    monsters = (List<Monster>)serializer.Deserialize(file, typeof(List<Monster>));
                }
            }
            return monsters;
        }

        public void OpslaanStudenten(List<Monster> monsters)
        {
            using (StreamWriter file = File.CreateText(Folder + FilenameMonster))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, monsters);
            }
        }

        #region Code to make sure the sourcefiles for 'Monster' is copied to the working directory and can be found.

        private bool CheckMonsterFile()
        {
            bool fileExists = File.Exists(Folder + FilenameMonster);
            if (!fileExists)
            {
                string sourceFileMonsters = DefineSourceFileDirectory() + FilenameMonster;
                if (File.Exists(sourceFileMonsters))
                {
                    File.Copy(sourceFileMonsters, Folder + FilenameMonster);
                }
                fileExists = File.Exists(Folder + FilenameMonster);
            }
            return fileExists;
        }


        private string DefineSourceFileDirectory()
        {
            string sourceFileDirectory = Directory.GetCurrentDirectory().ToLower();
            string binDirectory = Path.DirectorySeparatorChar + "bin" + Path.DirectorySeparatorChar;
            if (sourceFileDirectory.Contains(binDirectory))
                sourceFileDirectory = sourceFileDirectory.Remove(sourceFileDirectory.LastIndexOf(binDirectory));
            sourceFileDirectory += Path.DirectorySeparatorChar + "bestanden" + Path.DirectorySeparatorChar;
            return sourceFileDirectory;
        }

        #endregion
    }
}
