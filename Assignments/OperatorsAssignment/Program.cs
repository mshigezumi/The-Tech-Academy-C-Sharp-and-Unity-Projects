using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee alfa = new Employee();
            Employee bravo = new Employee();

            alfa.ID = 10;
            bravo.ID = 10;
            if (alfa == bravo)
            {
                Console.WriteLine(alfa.ID + " is the same as " + bravo.ID);
            }
            else
            {
                Console.WriteLine(alfa.ID + " is not the same as " + bravo.ID);
            }
            Console.Read();
        }
    }
}
