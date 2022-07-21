// this piece of code taken from the tutorial demonstrates that method parameters can have default values, making them optional
// this makes me curious how the code would know which method to run if there was also a CreateGreeting() with no parameters, rather than a string
// does the use of default values in this way render a parameterless method of the same name no longer unique?
// I will test in next program.

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
}