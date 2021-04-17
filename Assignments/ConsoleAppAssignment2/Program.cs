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
            string[] PhoneticAlphabet = { "Alfa", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel", "India", "Juliett" };
            Console.WriteLine("Input text to be added to each string");
            string add = Console.ReadLine();
            int i = 0;
            foreach (string letter in PhoneticAlphabet)
            {
                PhoneticAlphabet[i] = letter + add;
                i++;
            }
            foreach (string letter in PhoneticAlphabet)
            {
                Console.WriteLine(letter);
            }
            
        }
    }
}
