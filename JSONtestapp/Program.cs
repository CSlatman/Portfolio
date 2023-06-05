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
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Name = "Jason", Age = 25 });
            //customers.Add(new Customer { Name = "Nikki", Age = 20 });
            Customer customer = new Customer("Nikki", 25);
            
<<<<<<< Updated upstream
            string json = JsonConvert.SerializeObject(customers, Formatting.Indented);
            string fileName = "customers.json";
            File.WriteAllText(fileName, json);

            string jsonString = File.ReadAllText(fileName);
            Console.WriteLine(jsonString);

            Customer customerlist = JsonConvert.DeserializeObject<Customer>(jsonString);
            
=======
            var options = new JsonSerializerOptions { WriteIndented = true };

            string json = JsonSerializer.Serialize(customer);
            string fileName = "customer.json";
            File.WriteAllText(fileName, json);

            string jsonString = File.ReadAllText(fileName);

            // Console.WriteLine(jsonString);
            string jsonString2 = File.ReadAllText(fileName);
            Customer customer1 = JsonSerializer.Deserialize<Customer>(jsonString);
            

            Console.WriteLine($"Name: {customer1.Name}");
            Console.WriteLine($"Age: {customer1.Age}");
>>>>>>> Stashed changes
        }
    }
}