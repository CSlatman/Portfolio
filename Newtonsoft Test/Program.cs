using Newtonsoft.Json;
using System.Security.Principal;

namespace Newtonsoft_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string Folder = @"C:\JSON\";
            string FileNameWeapons = @"C:\JSON\Weapons.json";

            string jsonText = File.ReadAllText(FileNameWeapons);

            //var data = JsonConvert.DeserializeObject<Weapon>(jsonText);

            //Console.WriteLine(data.WeaponName);

            //Weapon weapon = JsonConvert.DeserializeObject<Weapon>(jsonText);

            //Console.WriteLine(weapon.WeaponName);
            //Console.WriteLine(weapon.WeaponDamage);

            string json = @"{
  'WeaponName': 'Axe',
  'WeaponDamage': 10,
  'CreatedDate': '2013-01-20T00:00:00Z',
  'Roles': [
    'User',
    'Admin'
  ]
}";

            Weapon weapon = JsonConvert.DeserializeObject<Weapon>(json);

            Console.WriteLine(weapon.WeaponName);
            Console.WriteLine(weapon.WeaponDamage);
            Console.WriteLine(weapon.Email);
            Console.ReadKey();
        }

            
    }
}
