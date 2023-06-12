using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System;

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

        public List<Student> InladenStudenten()
        {
            List<Student> studenten = new List<Student>();
            if (CheckStudentFile())
            {
                using (StreamReader file = File.OpenText(Folder + BestandsnaamStudenten))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    studenten = (List<Student>)serializer.Deserialize(file, typeof(List<Student>));
                }
            }
            return studenten;
        }

        public void OpslaanStudenten(List<Student> studenten)
        {
            using (StreamWriter file = File.CreateText(Folder + BestandsnaamStudenten))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, studenten);
            }
        }

        #region Code to make sure the sourcefiles for 'Klassen' and 'Studenten' are copied to the working directory and can be found.

        private bool CheckStudentFile()
        {
            bool fileExists = File.Exists(Folder + BestandsnaamStudenten);
            if (!fileExists)
            {
                string sourceFileStudenten = DefineSourceFileDirectory() + BestandsnaamStudenten;
                if (File.Exists(sourceFileStudenten))
                {
                    File.Copy(sourceFileStudenten, Folder + BestandsnaamStudenten);
                }
                fileExists = File.Exists(Folder + BestandsnaamStudenten);
            }
            return fileExists;
        }

        private bool CheckKlassenFile()
        {
            bool fileExists = File.Exists(Folder + BestandsnaamKlassen);
            if (!fileExists)
            {
                string sourceFileKlassen = DefineSourceFileDirectory() + BestandsnaamKlassen;
                if (File.Exists(sourceFileKlassen))
                {
                    File.Copy(sourceFileKlassen, Folder + BestandsnaamKlassen);
                }
                fileExists = File.Exists(Folder + BestandsnaamKlassen);
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
