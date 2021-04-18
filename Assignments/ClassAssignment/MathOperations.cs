using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    static class MathOperations
    {
        public static void Divide(int x)
        {
            x = x / 2;
            Console.WriteLine(x);
        }

        public static void Set(out int x, out int y)
        {
            x = 10;
            y = 2;
        }

        public static void Divide(int x, int y)
        {
            x = x / y;
            Console.WriteLine(x);
        }
    }
}
