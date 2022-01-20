using System;
using System.Collections.Generic;
using System.Text;

namespace day5Assignments
{
    internal class Quotient
    {

        public void Compute()
        {
            int dividend = 50, divisor = 8;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();

        }
    }
}
