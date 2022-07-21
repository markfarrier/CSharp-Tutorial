// code from tutorial demonstrating lambda expressions
// essentially just one-line method.
// reading through the rest of the lambda section, tutorial doesn't quite have a COMPLETE explanation about how the nitty gritty of the outputs and parameters work
// (can make some guesses but don't want to make assumptions)
// maybe this will become clearer later, but as a note to myself - it might be worth reading into if it doesn't.  What order does the outputs inputs go when defining the type.
// Does a function have to return a type?  Or can it be void?  Does it have to have a parameter in that case.  I assume if 2 inputs are defined and 3 are within the <> then it's
// pretty clear that one of the extras is the output.  Can 3 inputs be defined and then have the function return nothing (like a void method would)
// need to test this after I complete this lambda section.

// anyway, this code should return 5 because the expression is fed an input parameter of 4, which makes x (the defined input parameter) equal to 4.  Meaning the function will
// output 4 + 1 (i.e. x+1), which of course equals 5

using System;

public class Program
{
    public static void Main()
    {
        Func<int, int> addOne = x => x + 1; // this is the lambda expression
        Console.WriteLine(addOne(4));
    }
}