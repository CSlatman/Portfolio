using System;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            
            string json = JsonSerializer.Serialize(customers, options);
            string fileName = "customers.json";
            File.WriteAllText(fileName, json);

            string jsonString = File.ReadAllText(fileName);

            Console.WriteLine(jsonString);


            Customer customerList = JsonSerializer.Deserialize<Customer>(jsonString);
            

            Console.WriteLine($"Name: {customerList.Name}");
            Console.WriteLine($"Age: {customerList.Age}");
        }
    }
}