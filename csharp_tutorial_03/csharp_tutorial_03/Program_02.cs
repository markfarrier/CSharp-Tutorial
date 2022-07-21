using System;

class Program_02
{
    static void Main()
    {
        string greeting = "Hi **NAME**!";
        string name = "Amber";
        bool loud = true; // loud = true means lowercase
        Console.WriteLine(output(greeting, name, loud));
        loud = false; // loud = false means uppercase
        Console.WriteLine(output(greeting, name, loud));

    }
    static string output(string greeting, string name, bool loud)
    {
        string unformatted = greeting.Replace("**NAME**", name);
        string formatted;
        if (loud)
        {
            formatted = unformatted.ToUpper();
        }
        else
        {
            formatted = unformatted.ToLower();
        }
        return formatted;
    }
}
