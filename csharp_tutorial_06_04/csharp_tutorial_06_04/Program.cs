using System;

public class Program
{
    public static void Main()
    {
        int x = 10;
        bool isPositive = x > 0;
        if (isPositive)
        {
            Console.WriteLine("I'm in here!"); // this will print because x is positive, and therefore the bool "isPositive" defined by x > 0 is true.  This the if statement is true.
        }
    }
}