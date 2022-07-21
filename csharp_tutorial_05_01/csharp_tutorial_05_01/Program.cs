using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("TEST ONE:");
        Greet("");
        Console.WriteLine("TEST TWO:");
        Greet(null);
        Console.WriteLine("TEST THREE");
        Greet("Mark");
    }

    static void Greet(string name)
    {
        if (String.IsNullOrEmpty(name)) return;

        Console.WriteLine($"Hello, {name}!");
    }
}