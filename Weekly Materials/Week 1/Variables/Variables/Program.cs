﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integer values.
            int numJupiterMoons = 67;
            // You can concatenate a string with a number.
            Console.WriteLine("The number of moon's Jupiter has: " + numJupiterMoons);
            // You can also do math on numbers.
            Console.WriteLine(numJupiterMoons + 10);

            // Don't do this - type mismatch, creating an "int" variable but a "double" value.
            //int badInt = 55.5;

            // Floating point values.
            double salesTaxAmount = 0.07;
            Console.WriteLine("The sales tax in NJ: " + salesTaxAmount);
            float cost = 10.25f;

            // String values.
            string quoteOfTheDay = "Perfect is the enemy of good.";
            Console.WriteLine(quoteOfTheDay);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
