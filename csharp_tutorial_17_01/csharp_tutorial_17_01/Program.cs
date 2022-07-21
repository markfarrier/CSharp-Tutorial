// code from tutorial demonstrating how to catch an exception rather than have it interrupt the program

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        try
        {
            // To see the error, try changing to or adding invalid numbers
            int sum = SumNumberStrings(new List<string> { "5", "potato" });
            Console.WriteLine(sum);
        }
        catch (System.FormatException)
        {
            Console.WriteLine("List of numbers contained an invalid entry.");
        }
    }

    public static int SumNumberStrings(List<string> numbers)
    {
        int total = 0;
        foreach (string numberString in numbers)
        {
            total += int.Parse(numberString);
        }
        return total;
    }
}