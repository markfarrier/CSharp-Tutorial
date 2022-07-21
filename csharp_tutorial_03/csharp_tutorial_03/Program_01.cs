using System;

class Program_01
{
    static void Main()
    {
        string string1;
        string1 = "Hello";

        string string2 = "Hello";
        Console.WriteLine(string1);
        Console.WriteLine(string2);

        string empty1 = "";
        string empty2 = String.Empty;

        Console.WriteLine(empty1.Length); // prints nothing
        Console.WriteLine(empty2.Length); // prints nothing

        string emptyString = String.Empty;
        string nullString = null;

        Console.WriteLine(emptyString);
        Console.WriteLine(nullString);

        Console.WriteLine($"1st string is {emptyString.Length} characters long.");
        // Console.WriteLine($"2nd string is {nullString.Length} characters long.");

        string one = "abc";
        string two = "123";
        string combined = one + two; // "abc123"

        Console.WriteLine(combined);

        string original = "Test string";
        string capital = original.ToUpper(); // TEST STRING
        string lower = original.ToLower(); // test string
        string lower2 = "Another Test".ToLower(); // another test

        Console.WriteLine(original);
        Console.WriteLine(capital);
        Console.WriteLine(lower);
        Console.WriteLine(lower2);

        string input = " Steve "; // has a space at the start and end.
        string clean1 = input.TrimStart(); // "Steve "
        string clean2 = input.TrimEnd(); // " Steve"
        string clean3 = input.Trim(); // "Steve"
        string shortversion = input.Trim().Substring(0, 3); // "Ste"

        Console.WriteLine($"*{input}*");
        Console.WriteLine($"*{clean1}*");
        Console.WriteLine($"*{clean2}*");
        Console.WriteLine($"*{clean3}*");
        Console.WriteLine($"*{shortversion}*");

        string name = "Steve";
        string greet1 = $"Hello {name}!"; // Hello Steve!
        string greet2 = "Hello " + name + "!"; // Hello Steve!
        string greet3 = String.Format("Hello {0}!", name); // Hello Steve!
        string greetTemplate = "Hello **NAME**!";
        string greet4 = greetTemplate.Replace("**NAME**", name); // Hello Steve!

        Console.WriteLine(name);
        Console.WriteLine(greet1);
        Console.WriteLine(greet2);
        Console.WriteLine(greet3);
        Console.WriteLine(greetTemplate);
        Console.WriteLine(greet4);
    }
}