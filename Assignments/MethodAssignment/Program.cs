using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a second number (optional)");
            string input = Console.ReadLine();
            MathOperations math = new MathOperations();
            if (input != "")
            {
                int number2 = Convert.ToInt32(input);
                Console.WriteLine(math.Add(number, number2));
            }
            else
            {
                Console.WriteLine(math.Add(number));
            }
            Console.Read();
        }
    }
}
