// this program is me testing out lambda expression inputs and outputs

// it appears that func must have a input at least.

using System;

public class Program
{
    public static void Main()
    {
        const int four = 4;
        //Func<> addOne = Console.WriteLine("TEST");
        //addOne();
        Func<int, int> addOne = x => x + 1;
        //   Func<double, int, int> calcArea = (x, y) => Convert.ToDouble(x) * Convert.ToDouble(y); 
        // Func<double> twentyFive = () => calcArea(addOne(four), addOne(four)); // no parameters
        // conversion to double didn't work for some reason even when put on separately on each input variable

        Func<int, int, int> calcArea = (x, y) => x * y; // two parameters
        Func<double> twentyFive = () => calcArea(addOne(four), addOne(four)); // no parameters

        Console.WriteLine(twentyFive());

        Func<int, string> modifiedAddOne = x => Convert.ToString(x + 1);
        Console.WriteLine(modifiedAddOne(four));
     
        // the lesson here is I need to learn how to do conversions within a lambda expression
        // hopefully the rest of the tutorial makes this clearer

        // UPDATE: conversions were only messing up because I had the output at the start rather than the end
        // so, lambda's apparently must have an output, and that output is at the end.  That answers my most important questions.
    }
}
