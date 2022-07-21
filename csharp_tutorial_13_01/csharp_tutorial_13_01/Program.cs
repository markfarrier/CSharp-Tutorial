// code from tutorial demonstrating block scoping.
// This could equally occur within the WriteLine rather than defining a new string variable every loop
// i have added in code to demonstrate this (commented out)

// reading through the tutorial, it appears that the variables are used to demonstrate scope.  The message variable inside the first for loop no longer exists outside the for loop.
// thus commenting out the second message variable declaration should render the program uncompilable

using System;

public class Program
{
    public static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            string message = $"I ran this loop {i} times already.";
            Console.WriteLine(message);
         // Console.WriteLine($"I ran this loop {i} times already.");
        }
        for (int i = 0; i < 10; i++)
        {
            string message = $"I ran this loop {i} times already.";
            Console.WriteLine(message);
        }
    }
}