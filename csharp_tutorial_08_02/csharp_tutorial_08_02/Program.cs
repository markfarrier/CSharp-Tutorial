// same for loop except I'm experimenting with different initial values of i
// decided to write another for loop to loop through all the starting points

using System;

public class Program
{
    public static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"TEST ONE: Starting point is {i}");
            for (int j = i; j < 10; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine();
        }
    }
}
