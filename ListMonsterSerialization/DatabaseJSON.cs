using ListMonsterSerialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


namespace CSharpConsoleRPG
{
    public class DatabaseJSON
    {
        /// <summary>
        /// These are the properties that show where to save the Folder and the file name of the player.
        /// </summary>
        public const string Folder = @"C:\JSON\";
        public const string FilenameMonsters = "Monsters.json";

        public List<Monster> LoadInMonsters()
        {
            List<Monster> monsters = new List<Monster>();
            if (CheckMonstersFile())
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

        #region Code to make sure the sourcefiles for 'Monsters' are copied to the working directory and can be found.



        private bool CheckMonstersFile()
        {
            bool fileExists = File.Exists(Folder + FilenameMonsters);
            if (!fileExists)
            {
                string sourceFilePlayer = DefineSourceFileDirectory() + FilenameMonsters;
                if (File.Exists(sourceFilePlayer))
                {
                    File.Copy(sourceFilePlayer, Folder + FilenameMonsters);
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
