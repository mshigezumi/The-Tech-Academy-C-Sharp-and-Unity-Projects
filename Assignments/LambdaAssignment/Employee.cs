using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Employee : Person
    {
        public int ID;

        public Employee(int id, string fName, string lName)
        {
            ID = id;
            firstName = fName;
            lastName = lName;
        }


        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("Time to quit");
        }

        public static bool operator ==(Employee alfa, Employee bravo)
        {
            if (alfa.ID == bravo.ID)
                return true;
            else
                return false;

        }

        public static bool operator !=(Employee alfa, Employee bravo)
        {
            if (alfa.ID != bravo.ID)
                return true;
            else
                return false;
        }
    }
}