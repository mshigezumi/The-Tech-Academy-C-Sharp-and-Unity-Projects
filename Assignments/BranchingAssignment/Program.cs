﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
                Console.Read();
                return;
            }
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());
            double size = width + height + length;
            if (size > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                double total = (height * width * length * weight) / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + total.ToString("F"));
                Console.WriteLine("Thank you!");
            }
            Console.Read();
        }
    }
}
