using System;

public class Program
{
    public static void Main()
    {
        int a = 5;
        int b = 10;
        if ((a < b) && (b < 20))
        {
            Console.WriteLine("I'm in here!"); // this will print because both (a<b) is true AND (b<20) is true. If either is false, this will not print. 
        }
    }
}