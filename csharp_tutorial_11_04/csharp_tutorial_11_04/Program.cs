// Program is doing something different this time.
// This program would run just as well if you just had 2 methods (the displayGreeting and Main method), and parse the name into the DisplayGreeting method as a parameter.
// However, this tutorial section is demonstrating method's ability to return a value, when not declared as void.
// There are advantages of having the methods set up this way - as it allows the program to be more flexable and extendable (e.g. if another method needed to call CreateGreeting
// or perhaps if DisplayGreeting was modified in some way that required this separation for proper functionality.

using System;

public class Program
{
    public static void Main()
    {
        DisplayGreeting();
    }

    static string CreateGreeting(string name)
    {
        return $"Hi {name}!";
    }

    static void DisplayGreeting()
    {
        Console.WriteLine(CreateGreeting("Steve"));
    }
}