using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> alfa = new Employee<string>();
            alfa.things = new List<string>() { "Alfa", "Bravo", "Charlie", "Delta", "Echo" };
            Employee<int> bravo = new Employee<int>();
            bravo.things = new List<int>() { 1, 2, 3, 4, 5 };

            foreach (string item in alfa.things)
            {
                Console.WriteLine(item);
            }
            foreach (int item in bravo.things)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
