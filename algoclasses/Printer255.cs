using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myalgo.algoclasses
{
    internal class Printer255
    {
        public void print255Nums()
        {
            Console.WriteLine("Printing nums 1 - 255-------------");
            for (int i = 1; i <= 255; i++)
			    {
                    Console.WriteLine(i);
			    }
            Console.WriteLine("Print finish------------------");
        }
        public void printOddNums255()
        {
            Console.WriteLine("Printing odd nums up to 255------------");
            for (int i = 1; i <= 255; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Odd Print finished---------------");
        }
        public void print255PlusSum()
        {
            Console.WriteLine("Printing sum plus nums [0 - 255]------------");
            int totalSoFar = 0;
            for (int i = 0; i <= 255; i++)
            {
                totalSoFar += i;
                Console.WriteLine($"The current number is: {i}. Total so far is: {totalSoFar}");
            }
            Console.WriteLine("Printing End---------------");

        }
    }
}
