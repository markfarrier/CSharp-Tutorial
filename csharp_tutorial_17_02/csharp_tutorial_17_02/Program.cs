// same as before except we're using the "throw" keyword to throw an exception after catching one
// the writeline code is executed before the exception is rethrown

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
            throw;
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