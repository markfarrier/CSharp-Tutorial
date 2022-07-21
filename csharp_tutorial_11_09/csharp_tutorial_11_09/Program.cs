// this code lifted from the tutorial is demonstrating method overloads, which I already did in previous programs
// here I'm calling the parametered method from the parameterless method
// this is essentially doing the same thing as the default parameter (the parameterless method feeding it's own default into the parametered method)

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

    static string CreateGreeting()
    {
        // call version with more parameters, passing a default value
        return CreateGreeting("You");
    }

    static string CreateGreeting(string name)
    {
        return $"Hi {name}!";
    }
}