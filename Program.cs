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
                printArrayContents(oddArray);
                
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
    }
}