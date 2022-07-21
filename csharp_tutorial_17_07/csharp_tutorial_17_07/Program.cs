// more code demonstrating the finally block

// this is the same program as previous program csharp_tutorial_17_06, except this time I have removed
// the catch block to show the exception being thrown but still running the finally block

using System;

public class Program
{
    public static void Main()
    {
        try
        {
            TestMethod();
        }
        catch
        {
            Console.WriteLine("Exception at Main");
            throw;
        }
    }

    public static void TestMethod()
    {
        int[] array = new int[3];
        try
        {
            array[5] = 1;
        }
        finally
        {
            // This code will always run
            // even if your catch block re-throws
            Console.WriteLine("FINALLY!");
        }
        // Code here will run only if catch doesn't re-throw
        Console.WriteLine("Still ran.");
    }
}