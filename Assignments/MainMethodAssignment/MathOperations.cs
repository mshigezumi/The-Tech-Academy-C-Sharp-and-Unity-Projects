using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class MathOperations
    {
        public int Add(int x)
        {
            return 10 + x;
        }

        public int Add(decimal x)
        {
            return Convert.ToInt32(20 + x);
        }

        public int Add(string x)
        {
            return 30 + Convert.ToInt32(x);
        }
    }
}