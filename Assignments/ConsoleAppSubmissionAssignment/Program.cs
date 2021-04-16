using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmissionAssignment
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            bool go = true;
            while (go)
            {
                i++;
                if (i < 10)
                {
                    Console.WriteLine(i);
                }
                else if (i == 10)
                {
                    go = false;
                }
            }
            Console.WriteLine("--");
            i = 0;
            go = true;
            do
            {
                i++;
                if (i < 10)
                {
                    Console.WriteLine(i);
                }
                else if (i == 10)
                {
                    go = false;
                }
            }
            while (go);
            Console.Read();
        }
    }
}
