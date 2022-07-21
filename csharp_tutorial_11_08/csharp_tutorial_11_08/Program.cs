// here's the program testing adding a parameterless methods alongside one with all defaults
// I should have guessed that calling the method without a parameter would just default to the parameterless method.  Thought the program might get confused because the method that can accept
// a string as a parameter can also be called without any parameters due to its default parameter. (at least, it could be called if it weren't for the addition of the parameterless method)

using System;

public class Program
{
    public static void Main()
    {
        string greeting = CreateGreeting();
        Console.WriteLine($"Default Greeting: {greeting}");

        string customGreeting = CreateGreeting("Steve");
        Console.WriteLine($"Custom Greeting: {customGreeting}");
    }

    static string CreateGreeting(string name = "You")
    {
        return $"Hi {name}!";
    }
    static string CreateGreeting()
    {
        return "HELLO!";
    }
}