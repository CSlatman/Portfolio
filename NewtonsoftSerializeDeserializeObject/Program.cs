using Newtonsoft;
using System.Diagnostics.Metrics;
using System.Numerics;
using System;


namespace NewtonsoftSerializeDeserializeObject
{
    public class Program
    {
        static void Main(string[] args)
        {
           Account account = new Account(1, "name", "password", "email");

            Console.ReadLine();
        }
    }
}