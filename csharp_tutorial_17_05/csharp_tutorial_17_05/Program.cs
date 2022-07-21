// code demonstrating the finally block

// an exception is thrown in the try block
// it is caught (swallowed) and the catch block is run
// regardless of whether an exception is caught or not, the finally code will always execute after the try/catch blocks
// The last writeline "still ran" will run after the finally block

using System;

public class Program
{
    public static void Main()
    {
        try
        {
            throw new Exception("Let's play catch!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
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