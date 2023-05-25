using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinckesBakfietsAppProject
{
    public class Menu
    {
        // The first implementation of a menu for the user.
        public void choice()
        {
            // Intro to Binckes.
            Console.WriteLine("Welcome to the Binckes Bicycle App.");

            // The process starts with an explanation to ensure clarity.

            Console.WriteLine("This program will allow you to rent a bicycle with certain accessories.");
            Console.WriteLine("At first, you will be able to choose a bicycle which has a daily fee.");
            Console.WriteLine("After which you will be able to select the number of days to rent the bike.");
            Console.WriteLine("The program will then display the total cost of the rental fee for the bicycle itself.");

            Console.WriteLine("And then you'll be able to choose accessories to rent along with your bicycle, but ");
            Console.WriteLine("these are a one time fee for the entire duration of the rent.");

            Console.WriteLine("At the end, the total cost will be calculated and shown and you will be able to choose whether you want to complete your purchase.");

            // You select a type of bicycle (while seeing the daily cost),
            Console.WriteLine("There are 4 types of bicycles and each of them has an electric and non-electric option.");
            Console.WriteLine("");
            // then you select the amount of days you want to rent it.
            // Reminder that the accessories are a one time fee + a safety deposit that will be returned later.
        }
    }
}

