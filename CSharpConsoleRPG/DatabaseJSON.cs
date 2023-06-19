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
        public const string FilenamePlayer = "Player.json";
        


        #region Code to make sure the sourcefiles for 'Player' are copied to the working directory and can be found.



        private bool CheckPlayerFile()
        {
            bool fileExists = File.Exists(Folder + FilenamePlayer);
            if (!fileExists)
            {
                string sourceFilePlayer = DefineSourceFileDirectory() + FilenamePlayer;
                if (File.Exists(sourceFilePlayer))
                {
                    File.Copy(sourceFilePlayer, Folder + FilenamePlayer);
                }
                fileExists = File.Exists(Folder + FilenamePlayer);
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
