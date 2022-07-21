// again, code copied from tutorial, no edits made.  Very elementary - it's like last project except the array is an array of arrays.  This means every row might have different numbers of elements 

using System;

class Program
{
    static void Main()
    {
        int[][] jaggedArray = new int[4][]; // define first dimension
        jaggedArray[0] = new int[2] { 1, 2 }; // set values of first array
        Console.WriteLine(jaggedArray[0][0]); // first element in first row
        Console.WriteLine(jaggedArray[0][1]); // second element in first row

        // additional rows haven't yet been created/assigned
        Console.WriteLine(jaggedArray[1]); // value is null
    }
}
