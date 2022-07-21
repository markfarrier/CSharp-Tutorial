// code copied directly from tutorial
// incredibly elementary, it's just incrementing by a different number than 1

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Odd Numbers from 1-49:");
        for (int i = 1; i < 50; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}