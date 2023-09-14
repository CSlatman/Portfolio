using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BPS_CSharp_Console_RPG
{
    public class Database
    {
        private string saveFilePath;

        public Database(string filePath)
        {
            saveFilePath = filePath;
        }

        public void SaveData<T>(T data)
        {
            string json = JsonConvert.SerializeObject(data);
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
    }
}

