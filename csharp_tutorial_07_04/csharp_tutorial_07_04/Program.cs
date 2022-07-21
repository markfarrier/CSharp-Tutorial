// this is the program after conversion to while loop
// was a little confused about what the tutorial was asking me to do
// or rather, how exactly they wanted this solved
// e.g. there was suggestion to increment "number" and I couldn't figure out why
// it's possible a different solution was expected.
// this solution works though.
// specifically, it works to find any factors the inputted number has when divided
// by the candidate factor or natural number exponent of the candidate factor.

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Factors: ");
        int candidateFactor = 2;
        int remainder;
        int factor;
        while (number > 1) // convert this to while
        {
            while (candidateFactor <= number) // convert this to while
            {
                remainder = number % candidateFactor;
                factor = number / candidateFactor;
                if (remainder == 0 && factor != 1) // found a factor
                {
                    Console.Write(factor);
                    number = factor;
                }
                else
                {
                    break;
                }
                if ((number / candidateFactor) > 1) Console.Write(", ");

            }
            break;
        }
        Console.WriteLine();
    }
}
