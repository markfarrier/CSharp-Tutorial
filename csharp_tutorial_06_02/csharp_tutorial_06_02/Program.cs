using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(true && true);    // true
        Console.WriteLine(true && false);   // false
        Console.WriteLine(false && false);  // false

        Console.WriteLine(true || true);    // true
        Console.WriteLine(true || false);   // true
        Console.WriteLine(false || false);  // false

        Console.WriteLine(true ^ true);     // false
        Console.WriteLine(true ^ false);    // true
        Console.WriteLine(false ^ false);   // false

        Console.WriteLine(!true);           // false
        Console.WriteLine(!false);          // true
    }
}