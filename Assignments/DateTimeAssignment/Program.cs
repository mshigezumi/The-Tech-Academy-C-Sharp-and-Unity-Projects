using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine("Enter a number of hours: ");
            int input = Convert.ToInt32(Console.ReadLine());
            TimeSpan ts = new TimeSpan(0, input, 0, 0);
            Console.WriteLine(dt + ts);
            Console.Read();
        }
    }
}
