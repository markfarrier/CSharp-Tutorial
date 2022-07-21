// more code demonstrating the finally block

// here we see the finally block running even though an exception is thrown
// the finally block is executed before the catch block throws the exception up the chain

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
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
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