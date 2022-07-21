using System;

class Program
{
    static void Main()
    {
        int[] someIntegers = { 1, 2, 3 };

        int x = 1 + someIntegers[0]; // x = 2, as someIntegers[0] = 1, and 1+1 = 2
        Console.WriteLine(x);

        int y = 2 * someIntegers[2]; // y = 6, as someIntegers[2] = 3, and 3x2 = 6
        Console.WriteLine(y);

        someIntegers[2] = y; // someIntegers now contains { 1, 2, 6 }, as y = 6, and someIntegers[2] is the 3rd value in the array
        Console.WriteLine(someIntegers[0]);
        Console.WriteLine(someIntegers[1]);
        Console.WriteLine(someIntegers[2]);

        // following lines produces an exception - because 3 is out of range.  The length of the array is 3, but the index starts at 0.  Therefore the 3rd value is someIntegers[2].
        // someIntegers[3] is the fourth value in an array of length 3, and therefore doesn't exist.
        // I have commented out this following line to allow the code to run
    //    someIntegers[3] = 3; // EXCEPTION
    }
}