// startingNumber and endingNumber were previously defined within the tutorial code
// I modified it to accept user input instead

// This can crash if user input is a non-integer, as this exception isn't accounted for

using System;

public class Program
{
    public static void Main()
    {
        Console.Write("CHOOSE YOUR STARTING NUMBER: ");
        int startingNumber = int.Parse(Console.ReadLine()); // change to whatever value you want to start from
        Console.Write("CHOOSE YOUR ENDING NUMBER: ");
        int endingNumber = int.Parse(Console.ReadLine()); // change to whatever number you want to be the last displayed

        for (int i = startingNumber; i <= endingNumber; i++)
        {
            Console.WriteLine(i);
        }
    }
}