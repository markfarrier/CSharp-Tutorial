// this is the unmodified program from the tutorial

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Factors: ");
        if (number > 1) // convert this to while
        {
            int candidateFactor = 2;
            if (candidateFactor <= number) // convert this to while
            {
                if (number % candidateFactor == 0) // found a factor
                {
                    Console.Write(candidateFactor);
                    // divide number by the factor you found and assign this back to number
                    // print a comma if number is still greater than 1
                }
                // don't forget to increment factor!
            }
        }
        Console.WriteLine();
    }
}
