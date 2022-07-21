// code demonstrating the user of InnerException
// here we're capturing the exception at the highest level, but printing the stack trace of all exceptions caught in the chain and where they occur

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        try
        {
            // To see the error, try changing to or adding invalid numbers
            int sum = GrandParentMethod(new List<string> { "5", "potato" });
            Console.WriteLine(sum);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught at Main method");
            Console.WriteLine("List of numbers contained an invalid entry.");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
            var inner = ex.InnerException;
            while (inner != null)
            {
                Console.WriteLine(inner.StackTrace);
                inner = inner.InnerException;
            }
            throw;
        }
    }

    public static int GrandParentMethod(List<string> numbers)
    {
        try
        {
            return ParentMethod(numbers);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught at ParentMethod method", ex);
            throw new ArgumentException("You passed in bad data", ex);
        }
    }


    public static int ParentMethod(List<string> numbers)
	{
        return SumNumberStrings(numbers);

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