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

            Customer customer = new Customer("Nikki", 25);
            

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

        }
    }
}