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
    }
}