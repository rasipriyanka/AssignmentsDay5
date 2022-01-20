using System;
using System.Collections.Generic;
using System.Text;

namespace day5Assignments
{
    internal class LargestNumber
    {

        public void Large()
        {
            Console.WriteLine("Enter the First  numbers : ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second numbers : ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third numbers : ");
            int third = Convert.ToInt32(Console.ReadLine());
             if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine("The 1st Number is the greatest among three ");
                }
                else
                {
                    Console.WriteLine("The 2nd Number is the greatest among three ");

                }
            }
            else if (second < third)
                Console.WriteLine("The 2nd Number is the greatest among three ");
            else
                Console.WriteLine("The 3rd Number is the greatest among three ");

        }
    }
}
        
    }
}
