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

        public void countNumberOfIntsGreaterThanY(int[] numbers, int y)
        {
            Console.WriteLine("Begin counting of items greater than y-------------");
            int count = 0;
            foreach(int number in numbers)
            {
                if (number > y) 
                { 
                    count++;
                }
            }
            Console.WriteLine($"The number of items greater than {y} are {count}");
            Console.WriteLine("End of test----------------");
        }
        public void printMinMaxAverageInArray(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Please use an array with at least one value");
                return;
            }
            int min = int.MaxValue;
            int max = int.MinValue;
            double avg = 0;
            foreach(int number in array)
            {
                min = Math.Min(min, number);
                max = Math.Max(max, number);
                avg += (double)number / (double)array.Length;
            }
            Console.WriteLine($"The minimum value found is: {min}. The maximum value found is: {max}. The average value is: {avg}");
        }


    }
}
