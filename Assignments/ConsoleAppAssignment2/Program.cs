using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listPA = new List<string>();
            listPA.Add("Alfa");
            listPA.Add("Bravo");
            listPA.Add("Charlie");
            listPA.Add("Delta");
            listPA.Add("Echo");
            listPA.Add("Foxtrot");
            listPA.Add("Golf");
            listPA.Add("Hotel");
            listPA.Add("India");
            listPA.Add("Juliett");

            listPA.Add("Alfa");
            listPA.Add("Bravo");
            listPA.Add("Charlie");
            listPA.Add("Zulu");

            List<string> appeared = new List<string>();
            foreach (string item in listPA)
            {
                if (appeared.Contains(item))
                {
                    Console.WriteLine(item + " has already appeared in the list");
                }
                else
                {
                    Console.WriteLine(item + " has not already appeared in the list");
                    appeared.Add(item);
                }
            }

            Console.Read();


        }
    }
}
