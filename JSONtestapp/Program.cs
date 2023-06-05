using System;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace JSONtestapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Name = "Jason", Age = 25 });
            customers.Add(new Customer { Name = "Nikki", Age = 20 });

            var options = new JsonSerializerOptions { WriteIndented = true };
            
            string json = JsonConvert.SerializeObject(customers, Formatting.Indented);
            string fileName = "customers.json";
            File.WriteAllText(fileName, json);

            string jsonString = File.ReadAllText(fileName);
            Console.WriteLine(jsonString);

            Customer customerlist = JsonConvert.DeserializeObject<Customer>(jsonString);
            
        }
    }
}