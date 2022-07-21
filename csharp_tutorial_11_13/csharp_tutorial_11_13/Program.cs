// so here's some more lambda expressions, with more parameters

// so the twentyFive lambda expression is a parameterless calling the calcArea lambda expression supplying it's own default parameters of addOne(four) and addOne(four)
// addOne(four) adds one to the input parameter which is a const int 4 - outputting a value of 5
// this makes the calcArea expression (x*y) 5x5 when called by the twentyFive function 


using System;

public class Program
{
    public static void Main()
    {
        const int four = 4;
        Func<int, int> addOne = x => x + 1;
        Func<int, int, int> calcArea = (x, y) => x * y; // two parameters
        Func<int> twentyFive = () => calcArea(addOne(four), addOne(four)); // no parameters
        Console.WriteLine(twentyFive());
    }
}