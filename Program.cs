namespace MyAlgos
{
    public class Basic13
    {
        public static void Main()
        {
            // Using a for loop to print numbers 1 - 255
            // Syntax note: for loops need the 'for' keyword, variable, conditional, incrementer, and a code block
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }

            // Using a for loop print odd numbers 1 - 255
            // Same as above. Using math logic we know that adding 2 to an odd number is always odd
            // This works b/c i is always odd and we will never equal 256.
            for (int i = 1; i < 256; i += 2)
            {
                Console.WriteLine(i);
            }

            // Print sum and numbers 0 - 255. Like the first loop on line 10. However we need a variable to keep track of total
            int total = 0; // Our running total of i.
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine("Current number is: " + i); // Strings are immutable. This operation is not modifying the old string. It makes a new String.
                total = total + i; // We could write this as total += i
                Console.WriteLine("Total so far: " + total);
            }

            // Print the values in an array and intializing an array literal
            int[] intArray = { 1, 3, 5, 7, 9, 13 }; // Could also use new int[] { 1, 2, 3, 4...}
            for (int index = 0; index < intArray.Length; index++) // intArray.Length accesses the Length property of the array. Useful for iterating unknown sized arrays
            {
                Console.WriteLine(intArray[index]); // Syntax note: index is an integer value. putting it in the brackets means we are accessing the value at the specified index
            }

            // Print the largest value in the array.
            int maxSoFar;
            maxSoFar = intArray[0]; // We will use the first value of the previous array as the starting value of maxSoFar
            for (int index = 1; index < intArray.Length; index++) // We start at 1 b/c we are using the value at index 0
            {
                int value = intArray[index];
                if (value > maxSoFar)
                {
                    maxSoFar = value;
                }
            }
            Console.WriteLine("The max value is: " + maxSoFar);

            // Should work with negative values too
            int[] negativeArray = { -1, -30, 40, 10, -5, 50, -3 };
            maxSoFar = negativeArray[0]; // overriding the value of maxSoFar.
            for (int index = 1; index < negativeArray.Length; index++) // Note: index is scoped to the for loop so we are technically creating a new variable named index each time.
            {
                int value = negativeArray[index];
                if (value > maxSoFar)
                {
                    maxSoFar = value;
                }
            }
            Console.WriteLine("The max value of our mixed array is: " + maxSoFar);

            // Find
        }
    }
}