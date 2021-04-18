using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a number");
            int number = Convert.ToInt32(Console.ReadLine());
            MathOperations.Divide(number);
            Console.WriteLine("--");
            MathOperations.Set(out int x, out int y); //sets the variables to x = 10 and y = 2
            MathOperations.Divide(x, y);
            Console.Read();
        }
    }
}
