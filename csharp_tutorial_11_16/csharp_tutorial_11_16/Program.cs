// more code from tutorial
// this is just showing that variables of the same type can be used in place of, for example, a hardcoded integer?
// seems obvious though

// copying in the tip here
//  Before using an extension method, your code will require a using statement
//  for the namespace of your static class containing the extension method (if
//  different from where you're accessing the extension method).


using System;

public class Program
{
    public static void Main()
    {
        int luckyNumber = 10;
        Console.WriteLine(luckyNumber); // Will output 10
        int result = luckyNumber.PlusFive();
        Console.WriteLine(result); // Will output 15
    }
}

public static class ExtensionMethods
{
    public static int PlusFive(this int input)
    {
        return input + 5;
    }
}