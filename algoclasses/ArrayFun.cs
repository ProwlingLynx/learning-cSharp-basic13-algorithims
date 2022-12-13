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

        public void printAverageTotalInIntArray(int[] numbersArray)
        {
            Console.WriteLine("Test start---------------");
            int totalSum = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                totalSum += numbersArray[i];
            }
            double average = (double)totalSum / (double)numbersArray.Length;
            Console.WriteLine($"There are: {numbersArray.Length} numbers. The total is: {totalSum}. The average is: {average}");
            Console.WriteLine("End of test----------------------");
        }

        public int[] returnArrayOfOddIntsSize255()
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 255; i+= 2)
            {
                numbers.Add(i);
            }
            return numbers.ToArray();
        }
    }
}
