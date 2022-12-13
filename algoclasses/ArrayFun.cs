using System;

namespace myalgo.algoclasses
{
    internal class ArrayFun
    {
        public void printContentsOfArray(int[] numbersArray)
        {
            Console.WriteLine("Printing contents of input array---------");
            foreach (int number in numbersArray)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("\nTest end.---------------------");
        }
        public void printMaxValueInArray(int[] numbersArray)
        {
            Console.WriteLine("Find max value start------------");
            if (numbersArray.Length == 0)
            {
                Console.WriteLine("Please pass in an array of integers of size 1 minimum.");
                return;
            }
            int largestValueSoFar = int.MinValue;
            foreach(int number in numbersArray)
            {
                largestValueSoFar = Math.Max(largestValueSoFar, number);
            }
            Console.WriteLine($"The largest value in the array is: {largestValueSoFar}");
            Console.WriteLine("End test------------------------");
        }
    }
}
