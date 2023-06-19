using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonsoftSerializeDeserializeObject
{
    public class JSONManager
    {
        public const string Folder = @"C:\JSON\";
        public const string FileNameAccount = "Account.json";

        public void Serialize()
        {

        }

        public void Deserialise()
        {
            Account account1 = JsonConvert.DeserializeObject<Account>(File.ReadAllText(@"c:\movie.json"));

            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(@"c:\movie.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                Account account = (Account)serializer.Deserialize(file, typeof(Account));
            }
        }
    }
        
}
