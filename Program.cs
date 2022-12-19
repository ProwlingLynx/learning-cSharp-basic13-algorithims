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
                Console.WriteLine("Current number is: " + i);
                total = total + i; // We could write this as total += i
                Console.WriteLine("Total so far: " + total);
            }
        }
    }
}