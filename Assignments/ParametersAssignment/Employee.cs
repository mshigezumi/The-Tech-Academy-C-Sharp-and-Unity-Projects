using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Employee<gen> : Person
    {
        public int ID;
        public List<gen> things;

        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("Time to quit");
        }

        public static bool operator ==(Employee<gen> alfa, Employee<gen> bravo)
        {
            if (alfa.ID == bravo.ID)
                return true;
            else
                return false;

        }

        public static bool operator !=(Employee<gen> alfa, Employee<gen> bravo)
        {
            if (alfa.ID != bravo.ID)
                return true;
            else
                return false;
        }
    }
}
