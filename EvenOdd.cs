using System;
using System.Collections.Generic;
using System.Text;

namespace day5Assignments
{
    internal class EvenOdd
    {
        public void EvenNumbers()
        {

            Console.Write("Enter a Number : ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
        }
    }

