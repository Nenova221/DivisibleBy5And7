using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy5And7
{
    public class DivisibleBy5And7
    {
        public static bool IsDivisibleBy5And7(int input)
        {
            return (input % 35 == 0);
            Console.WriteLine("{0} is divisible by both 5 and 7");
        }
    }
}
