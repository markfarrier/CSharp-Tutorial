// this code demonstrates the use of polymorphism to catch specific exceptions
// the generic exception must go at the end as the program will check for exceptions
// in the order it is written in the code.  Therefore if ANY exception is caught then
// it will be caught by the generic catch, making any subsequent code essentially useless.
// (if it was going to catch ANYTHING it will catch on the generic)

using System;

public class Program
{
    public static void Main()
    {
        try
        {
            // uncomment either line to see an error
            //int.Parse("A");
            //throw new Exception();
        }
        catch (System.FormatException)
        {
            Console.WriteLine("This is a System.FormatException");
        }
        catch (System.Exception)
        {
            Console.WriteLine("This is a different System.Exception");
        }
    }
}