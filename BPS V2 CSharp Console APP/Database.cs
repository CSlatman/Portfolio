using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BPS_V2_CSharp_Console_APP
{
    public class Database
    {
        public const string Folder = @"C:\JSON\";
        public const string FilenamePlayer = "Player.json";

        private string saveFilePath;

        public Database()
        {
            // Combine the folder and filename to get the complete path
            saveFilePath = Path.Combine(Folder, FilenamePlayer);

            // Check if the player file exists, if not, copy it from the source directory
            if (!File.Exists(saveFilePath))
            {
                bool fileCopied = CheckPlayerFile();
                if (!fileCopied)
                {
                    Console.WriteLine("Failed to copy the player file.");
                }
            }
        }

        public void SaveData<T>(T data)
        {
            string json = JsonConvert.SerializeObject(data);

            // Ensure the directory exists
            Directory.CreateDirectory(Folder);

            File.WriteAllText(saveFilePath, json);
        }

        public T LoadData<T>() where T : new()
        {
            if (File.Exists(saveFilePath))
            {
                string json = File.ReadAllText(saveFilePath);
                return JsonConvert.DeserializeObject<T>(json);
            }
            else
            {
                Console.WriteLine("No saved data found.");
                return new T();
            }
        }

        #region Code to make sure the sourcefiles for 'Player' are copied to the working directory and can be found.

        private bool CheckPlayerFile()
        {
            string sourceFilePlayer = DefineSourceFileDirectory() + FilenamePlayer;
            if (File.Exists(sourceFilePlayer))
            {
                File.Copy(sourceFilePlayer, saveFilePath);
                return true;
            }

            return false;
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
