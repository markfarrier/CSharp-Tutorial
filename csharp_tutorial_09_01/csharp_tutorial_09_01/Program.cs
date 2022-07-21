// instead of copying the code from the tutorial, and going through each element individually in the code
// I have modified this so that it does a for loop through the array, utilizing the Length property

// I have also separated this out into it's own method

using System;

class Program
{
    static void Main()
    {
        int[] someIntegers = new int[3]; // holds 3 elements, with indexes of 0, 1, and 2.
        // uninitialized elements of a declared array hold the default value for the type (in this case 0).
        int[] moreIntegers = new int[] { 1, 2, 3, 4, 5 }; // initializes the values of the array
        int[] otherIntegers = new[] { 1, 3, 5, 7, 9 }; // you can omit `int` and just specify []; type is inferred

        Console.WriteLine("TEST ONE: int[] someIntegers = new int[3]");
        writeArray(someIntegers);
        Console.WriteLine("TEST TWO: int[] moreIntegers = new int[] { 1, 2, 3, 4, 5 }");
        writeArray(moreIntegers);
        Console.WriteLine("TEST THREE: int[] otherIntegers = new[] { 1, 3, 5, 7, 9 }");
        writeArray(otherIntegers);

    }
    static void writeArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine();
    }
}
