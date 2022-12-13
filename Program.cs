using myalgo.algoclasses;



namespace myalgo
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");
            try
            {
                Printer255 testPrint255 = new Printer255();
                testPrint255.print255Nums();
                testPrint255.printOddNums255();
                testPrint255.print255PlusSum();


                int[] testArray = createArrayOfIntsOfNSized(10);
                Console.WriteLine("Expect nums 0 - 9 values in size 10 array------------");
                Console.WriteLine(String.Join(", ", testArray));
                Console.WriteLine("Array test end----------");

                ArrayFun arrayMethodsTest = new ArrayFun();
                arrayMethodsTest.printContentsOfArray(testArray);
                arrayMethodsTest.printMaxValueInArray(testArray);
                //Can it handle negatives?

                int[] arrayWithNegativeValues = createArrayOfIntsOfNSized(10, -4);
                Console.WriteLine("Expect nums [-4, 6] values in size 10 array------------");
                Console.WriteLine(String.Join(", ", arrayWithNegativeValues));
                Console.WriteLine("Array test end----------");

                arrayMethodsTest.printMaxValueInArray(arrayWithNegativeValues);
                arrayMethodsTest.printAverageTotalInIntArray(testArray);
                arrayMethodsTest.printAverageTotalInIntArray(arrayWithNegativeValues);
                int[] oddArray = arrayMethodsTest.returnArrayOfOddIntsSize255();
                
                printArrayContents(testArray);
                arrayMethodsTest.countNumberOfIntsGreaterThanY(testArray, 3);
                printArrayContents(arrayWithNegativeValues);
                arrayMethodsTest.countNumberOfIntsGreaterThanY(arrayWithNegativeValues, 1);

                printArrayContents(testArray);
                int[] actual1 = mapValuesInArrayBySquaringEachValue(testArray);
                printArrayContents(actual1);

                printArrayContents(arrayWithNegativeValues);
                replaceValuesInArrayLessThanZeroWithZero(arrayWithNegativeValues);
                printArrayContents(arrayWithNegativeValues);

                arrayMethodsTest.printMinMaxAverageInArray(testArray);
                arrayMethodsTest.printMinMaxAverageInArray(actual1);

                printArrayContents(testArray);
                shiftArrayByOne(testArray);
                printArrayContents(testArray);

                int[] finalSample = new int[] { 1, 5, 10, 7, -2 };
                printArrayContents(finalSample);
                string[] actual2 = mapValuesToStringAndReplaceNegativeValues(finalSample);
                printArrayContents(actual2);
            } catch (Exception ex)
            {
                Console.WriteLine("Test failed!");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }

        }
        public static int[] createArrayOfIntsOfNSized(int n)
        {
            int[] ints = new int[n];
            for (int i = 0; i < n; i++)
            {
                ints[i] = i;
            }
            return ints;
        }
        public static int[] createArrayOfIntsOfNSized(int n, int startValue)
        {
            int[] ints = new int[n];
            int index = 0;
            for (int i = startValue; i < startValue + n; i++)
            {
                ints[index++] = i;
            }
            return ints;
        }
        public static void printArrayContents(int[] array)
        {
            Console.WriteLine("Start of array print ------------------");
            foreach(int number in array)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("\nEnd of array print ----------------");
        }
        public static void printArrayContents(string[] array)
        {
            Console.WriteLine("Start of array print ------------------");
            foreach(string number in array)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("\nEnd of array print ----------------");
        }
        public static int[] mapValuesInArrayBySquaringEachValue(int[] array)
        {
            Console.WriteLine("Start of array mapping-------------");
            int[] mappedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                mappedArray[i] = (int)Math.Pow(array[i], 2);
            }
            Console.WriteLine("End of array mapping-----------------");
            return mappedArray;
        }
        public static int[] replaceValuesInArrayLessThanZeroWithZero(int[] array)
        {
            Console.WriteLine("Test start-------------------");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Max(array[i], 0);
            }
            Console.WriteLine("Test end-----------------------");
            return array;
        }
        public static void shiftArrayByOne(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Please pass in an array with at least one value in it");
                return;
            }
            Console.WriteLine("Shifting array by one---------------");
            for(int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = 0;
            Console.WriteLine("Array has been shifted successfully!---------------------------");
        }
        public static string[] mapValuesToStringAndReplaceNegativeValues(int[] array)
        {
            if(array.Length == 0)
            {
                Console.WriteLine("Please pass in a non MT array");
                return new string[0];
            }
            Console.WriteLine("Start of mapping values with string--------------------");
            string[] outputArray = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    outputArray[i] = "Dojo";
                } else
                {
                    outputArray[i] = array[i].ToString();
                }
            }
            Console.WriteLine("End of mapping values with strings--------------------");
            return outputArray;
        }
    }
}