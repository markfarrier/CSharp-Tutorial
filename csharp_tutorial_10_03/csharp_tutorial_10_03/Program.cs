// using the code from the tutorial
// it's meant to demonstrate how you can use the Length and Count variables to loop through an array
// I have already done this in previous projects within this tutorial (with "Length", not "Count")

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // List<T>
        var myList = new List<int>() { 43, 55, 100 };
        for (int i = 0; i < myList.Count; i++)
        {
            // access current element of the list with index of i
            Console.WriteLine(myList[i]);
        }

        // array
        int[] numbers = new[] { 2, 3, 5, 7 };
        for (int i = 0; i < numbers.Length; i++)
        {
            // access current element of the array with index of i
            Console.WriteLine(numbers[i]);
        }
    }
}
