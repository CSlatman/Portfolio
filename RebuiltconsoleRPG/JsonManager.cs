using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System;

namespace RebuiltconsoleRPG
{
    public class JsonManager
    {
        /// <summary>
        /// These are the properties that show where to save the Folder and the file name of the students / classses.
        /// </summary>
        public const string Folder = @"C:\JSON\";
        public const string FilenameMonsters = "Monsters.json";


        public List<Monster> LoadMonsters()
        {
            List<Monster> monsters = new List<Monster>();
            if (CheckMonsterFile())
            {
                using (StreamReader file = File.OpenText(Folder + FilenameMonsters))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    monsters = (List<Monster>)serializer.Deserialize(file, typeof(List<Monster>));
                }
            }
            return monsters;
        }

        public void SaveMonsters(List<Monster> monsters)
        {
            using (StreamWriter file = File.CreateText(Folder + FilenameMonsters))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, monsters);
            }
        }

        #region Code to make sure the sourcefiles for 'Klassen' and 'Studenten' are copied to the working directory and can be found.

        private bool CheckMonsterFile()
        {
            bool fileExists = File.Exists(Folder + FilenameMonsters);
            if (!fileExists)
            {
                string sourceFileMonsters = DefineSourceFileDirectory() + FilenameMonsters;
                if (File.Exists(sourceFileMonsters))
                {
                    File.Copy(sourceFileMonsters, Folder + FilenameMonsters);
                }
                fileExists = File.Exists(Folder + FilenameMonsters);
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
