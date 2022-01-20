using System;
using System.Collections.Generic;
using System.Text;

namespace day5Assignments
{
    internal class FlipCoin
    {
        public  void FindFlipCoinPercentage()
        {
            int tailCount = 0;
            int headCount = 0;
            Console.WriteLine("No of times you want to flip coin: ");
            int numOfTimes = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            for (int i = 0; i<numOfTimes; i++)
            {
                double randomValue = random.NextDouble();
                if (randomValue < 0.5) tailCount++;
                else headCount++;
            }
            Console.WriteLine("Total tail count is " + tailCount + " out of " + numOfTimes);
            Console.WriteLine("Total head count is " + headCount + " out of " + numOfTimes);
            Console.WriteLine("Total head " + (double)(headCount * 100) / numOfTimes + "%");
            Console.WriteLine("Total tail " + (double)(tailCount * 100) / numOfTimes + "%");
        }
    }
}

