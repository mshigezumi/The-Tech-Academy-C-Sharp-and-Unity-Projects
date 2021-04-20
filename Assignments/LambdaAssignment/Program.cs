using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee(1, "Joe", "Alfa"),
                new Employee(2, "B.", "Bravo"),
                new Employee(3, "C.", "Charlie"),
                new Employee(4, "D.", "Delta"),
                new Employee(5, "E.", "Echo"),
                new Employee(6, "Joe", "Foxtrot"),
                new Employee(7, "G.", "Golf"),
                new Employee(8, "H.", "Hotel"),
                new Employee(9, "I.", "India"),
                new Employee(10, "J.", "Juliett")
            };

            //foreach loop
            List<Employee> list2 = new List<Employee>();
            foreach (Employee person in list)
            {
                if (person.firstName == "Joe")
                {
                    list2.Add(person);
                }
            }

            foreach (Employee person in list2)
            {
                Console.WriteLine(person.firstName + " " + person.lastName);
            }
            Console.WriteLine("--");

            //lambda variation
            List<Employee> list3 = list.Where(person => person.firstName == "Joe").ToList();

            foreach (Employee person in list3)
            {
                Console.WriteLine(person.firstName + " " + person.lastName);
            }
            Console.WriteLine("--");

            //ID>5 with lambda
            List<Employee> list4 = list.Where(person => person.ID > 5).ToList();

            foreach (Employee person in list4)
            {
                Console.WriteLine(person.firstName + " " + person.lastName);
            }

            Console.Read();
        }
    }
}
