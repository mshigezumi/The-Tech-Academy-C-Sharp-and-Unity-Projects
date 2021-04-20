using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day");
            string input = Console.ReadLine();
            try
            {
                if (Enum.TryParse(input, out Day day))
                {
                    Console.WriteLine("day has been set to: " + day);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.Read();
            }
            Console.Read();
        }
        public enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
