// code from tutorial demonstrating throwing an exception from the catch block

// here we see the low-level exception thrown in FindStudentID being passed up the chain to DoWork then Main via the InnerException property

using System;

public class Program
{
    public static void Main()
    {
        try
        {
            DoWork();
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("We encountered an error. Please try again.");
            Console.WriteLine(ex.Message);
        }
    }

    public static void DoWork()
    {
        try
        {
            FindStudentId(null);
        }
        catch (ArgumentNullException ex)
        {
            // You would do some safe clean up work or logging here
            // Logger.LogError(ex);
            throw;
        }
    }

    public static int FindStudentId(string studentName)
    {
        if (string.IsNullOrEmpty(studentName))
        {
            throw new ArgumentNullException(nameof(studentName));
        }

        return 0; // we didn't really implement this
    }
}