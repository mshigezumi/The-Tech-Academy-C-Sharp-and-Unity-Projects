using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorsAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1\nHourly Rate?");
            double rate1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            double hours1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Person 2\nHourly Rate?");
            double rate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            double hours2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Annual salary of Person 1:");
            double result1 = rate1 * hours1 * 52;
            Console.WriteLine(result1);
            Console.WriteLine("Annual salary of Person 2:");
            double result2 = rate2 * hours2 * 52;
            Console.WriteLine(result2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compare = result1 > result2;
            Console.WriteLine(compare);
            Console.Read();
        }
    }
}
