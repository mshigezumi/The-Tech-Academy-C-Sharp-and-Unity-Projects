using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment3
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<int> list = new List<int>();
                list.Add(10);
                list.Add(20);
                list.Add(30);
                list.Add(40);
                list.Add(50);
                list.Add(60);
                list.Add(70);
                list.Add(80);
                list.Add(90);
                list.Add(100);
                Console.WriteLine("Input a number to divide by");
                int number = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i] / number);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Program has emerged from try/catch block");
            Console.Read();
        }
    }
}
