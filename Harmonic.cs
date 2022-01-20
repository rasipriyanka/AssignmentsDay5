using System;
using System.Collections.Generic;
using System.Text;

namespace day5Assignments
{
    internal class Harmonic
    {
		public static double HarmonicValue(double n)
		{
		int num = Convert.ToInt32(Console.ReadLine());

			double num = 0.0;

			for (int i = 1; i <= num; i++)
			{
				
				num = num + (1.0/i);
			}
			return num;
		}
	}
}
