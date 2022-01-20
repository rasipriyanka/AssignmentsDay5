using System;
using System.Collections.Generic;
using System.Text;

namespace day5Assignments
{
    internal class PowersOfTwo
    {
        public void Power()
        {
            Console.WriteLine("Enter the number:");
            int N= Convert.ToInt32(Console.ReadLine());
            if(0<=N && N<=31)
            {
                for(int i = 1; i<=N; i++)
                {
                    Console.Write("Power of 2^"+i+" is: "+(Math.Pow(2, i)));
                }
            }
            else
            {
                Console.WriteLine("Number Not exists");
            }
        }
       
    }
}
