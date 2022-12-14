using System.Collections;

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
            // This works b/c i is always odd.
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

            // Find the average of a given array.
            // average is defined as the total of a list of numbers divided by the number of values added together.
            // We can break this up into add total, get the size of the list, divide by the size of the list
            int totalValueOfList = 0;
            int[] listOfNumbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int index = 0; index < listOfNumbers.Length; index++)
            {
                totalValueOfList += listOfNumbers[index];
            }

            int sizeOfList = listOfNumbers.Length;

            int averageOfList = totalValueOfList / sizeOfList;
            // We can make this very terse using the value in a long chaing, but for learning we are being verbose here.
            Console.WriteLine("The average of our list is: " + averageOfList);

            // Find all values greater than Y.
            // We are only interested in the number of values greater than Y. Not their values
            int countOfValuesGreaterThanY = 0;
            int Y = 4;
            for (int index = 0; index < listOfNumbers.Length; index++)
            {
                int value = listOfNumbers[index]; // Every time the loop iterates this value is recreated and assigned.
                if (value > Y)
                {
                    countOfValuesGreaterThanY++;
                }
            }
            Console.WriteLine("The total number of values greater than Y is: " + Y);

            // Create an array with all odd values between 1 and 255;
            // We can re use our previous solution that printed odd values between 1 and 255 and refactor it.
            // Since we are not sure about the number of values in the final array we should use a list.
            // Lists can be of variable lengths. Unlike arrays
            // Time to make a method!
            CreateArrayOfOddNumbers();

            // Create a method that takes an array and returns the number of values greater than Y in the array
            // We did something similar before, lets reuse it!
            // This method will have two parameters and return a value
            // Something I learned early on in my journey: I have yet to see a function/method return more than one thing at a time ;D
            int[] testArray = { 100, 200, 300, 400, 500, 600, 700, 800 };
            int numberGreaterThanY = CountValuesGreaterThanY(testArray, 433);
            Console.WriteLine("Number of values greater than in our test array is: " + numberGreaterThanY);

            // Square values in the original array
            // Note: We are not making a new array. Rather we are mutating the original.
            // cont'd: Any value we pass to a method that is a reference can be modified by the method. This is called a side effect.
            int[] numbersSquared = { 1, 2, 3, 4, 5, 6 };
            SquareValuesInTheArray(numbersSquared);
            // We need to know if it worked. So lets try out a foreach this time.
            foreach (int value in numbersSquared) // Syntax note: keyword foreach, variable, keyword in, array/ArrayList
            {
                Console.WriteLine(value);
            }

            // Eliminate all negative numbers in an array by replacing them with 0
            // We can reuse our old code for counting values greater than Y
            // Lets build a method that does this and prints the values.
            int[] negativeTestArray2 = { -1, 3, -3, -4, 80, -888 };
            ReplaceNegativeValuesWithZero(negativeTestArray2);

            // This method displays the min, max, and avg in a given array.
            // We have solved all these problems before. Lets make the method
            // and combine them.
            int[] mixedArray = { -1, 2, 3, 4, -5, -7, 10 };
            DisplayMinMaxAvg(mixedArray);

            // Shift each value in an array by one to the left and replace the value with a zero
            // Lets try and use an Array List and see how it goes.
            ArrayList mixedList = new ArrayList();
            mixedList.Add(1);
            mixedList.Add(2);
            mixedList.Add(3);
            mixedList.Add(4);
            mixedList.Add(5);
            ShiftArrayByOne(mixedList);

            // Replace all negative values with a dojo string
            // We have solved a similar issue with count with Y.
            // The challenge here is that we cannot put a string value into an int array
            // Therefore we must use an arrayList as our final form.
            
            int[] allNegativeValues = { -1, -2, -3, -4, -5, -6 };
            ReplaceNEgativesWithDojo(allNegativeValues);

            int[] mixedNegativesAndPositives = { -1, -2, -3, -4, -5, -6, 1, 2, 3, 4, 5 };
            ReplaceNEgativesWithDojo(mixedNegativesAndPositives);
        }
        // the keyword static means a method that is located on the class, not the object.
        public static void CreateArrayOfOddNumbers()
        {
            ArrayList myList = new ArrayList(); // Notes: ArrayList can be of any size (memory allowing) and can store any data type. Mixed types included!
            for (int i = 1; i < 256; i += 2)
            {
                myList.Add(i); // Unlike an array, we must use the method Add() in order to add a value to the list myList represents.
            }
            // We need to know if our method worked. Time to iterate over our list using the good ol' for loop
            for (int index = 0; index < myList.Count; index++) // Note: Use the Count property instead of Length
            {
                Console.WriteLine(myList[index]); // ArrayList has some overlapping features with Arrays. We can access the value at index using bracket notation. 
            }
        }
        public static int CountValuesGreaterThanY(int[] array, int Y)
        {
            int count = 0;
            for (int index = 0; index < array.Length; index++)
            {
                int value = array[index];
                if (value > Y)
                {
                    count++;
                }
            }
            return count;
        }
        public static void SquareValuesInTheArray(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                int value = array[index];
                array[index] = value * value; // We access the array and reassign the value through math.
            }
        }
        public static void ReplaceNegativeValuesWithZero(int[] array)
        {
            // A little touch up here.
            for (int index = 0; index < array.Length; index++)
            {
                int value = array[index]; 
                if (value < 0)
                {
                    array[index] = 0;
                }
            }
            // lets make sure it worked.
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }

        }
        public static void DisplayMinMaxAvg(int[] array)
        {
            // We can refactor the solution and make it more elegant, but
            // The idea is to highligtht that we did solve these problems before

            int maxSoFar;
            maxSoFar = array[0]; 
            for (int index = 1; index < array.Length; index++) 
            {
                int value = array[index];
                if (value > maxSoFar)
                {
                    maxSoFar = value;
                }
            }
            Console.WriteLine("The max value is: " + maxSoFar);

            int totalValueOfList = 0;
            int[] listOfNumbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int index = 0; index < listOfNumbers.Length; index++)
            {
                totalValueOfList += listOfNumbers[index];
            }

            int sizeOfList = listOfNumbers.Length;

            int averageOfList = totalValueOfList / sizeOfList;
            // We can make this very terse using the value in a long chaing, but for learning we are being verbose here.
            Console.WriteLine("The average of our list is: " + averageOfList);

            int minSoFar;
            minSoFar= array[0];
            for (int index = 1; index < array.Length; index++)
            {
                int value = array[index];
                if (value < minSoFar)
                {
                    minSoFar = value;
                }
            }
            Console.WriteLine("The min value is: " + minSoFar);
        }
        public static void ShiftArrayByOne(ArrayList arrayList)
        {
            arrayList.RemoveAt(0);// RemoveAt removes element at given index
            arrayList.Add(0); // Now we add our zero
            //Lets make sure we did it correctly
            foreach(int value in arrayList)
            {
                Console.WriteLine(value);
            }
        }
        public static void ReplaceNEgativesWithDojo(int[] array)
        {
            ArrayList myList = new ArrayList();
            for (int index = 0; index < array.Length; index++)
            {
                int value = array[index]; // Every time the loop iterates this value is recreated and assigned.
                if (value < 0)
                {
                    myList.Add("Dojo");
                } else
                {
                    myList.Add(value);
                }
            }

            // Just like always, lets make sure it works!
            foreach(var value in myList) // var is a lazy way of saying we have no idea what the expected type is
            {
                // In this case we should use var since our list is mixed.
                Console.WriteLine(value);
            }
        }
    }
}