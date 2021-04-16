using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAssignment
{
    class Program
    {
        static void Main()
        {
            string[] PhoneticAlphabet = { "Alfa", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel", "India", "Juliett" };
            Console.WriteLine("Select an index of the array (0-9)");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index > 9 || index < 0)
            {
                Console.WriteLine("That index does not exist");
            }
            else
            {
                Console.WriteLine(PhoneticAlphabet[index]);
            }

            int[] numbers = { 10, 100, 1000, 10000, 100000 };
            Console.WriteLine("Select an index of the array (0-4)");
            index = Convert.ToInt32(Console.ReadLine());
            if (index > 4 || index < 0)
            {
                Console.WriteLine("That index does not exist");
            }
            else
            {
                Console.WriteLine(numbers[index]);
            }

            List<string> list = new List<string>();
            list.Add("Alfa");
            list.Add("Bravo");
            list.Add("Charlie");
            list.Add("Delta");
            list.Add("Echo");
            list.Add("Foxtrot");
            list.Add("Golf");
            list.Add("Hotel");
            list.Add("India");
            list.Add("Juliett");
            Console.WriteLine("Select an index of the array (0-9)");
            index = Convert.ToInt32(Console.ReadLine());
            if (index > 9 || index < 0)
            {
                Console.WriteLine("That index does not exist");
            }
            else
            {
                Console.WriteLine(list[index]);
            }
            Console.Read();
        }
    }
}
