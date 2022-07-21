using System;

class Program
{
    static void Main(string[] args)
    // greeting formatted such that it expects a "**NAME**" within to replace with the name argument;
    // args[3] expects a string of either "loud" or "quiet";
    {
        string unformatted;
        string formatted;
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter parameter values");

        }
        if (args.Length == 1)
        {
            Console.WriteLine("Program requires at least 2 parameters");

        }
        if (args.Length == 2)
        {
            unformatted = args[0].Replace("**NAME**", args[1]);
            Console.WriteLine(unformatted);
        }
        if (args.Length == 3)
        {
            unformatted = args[0].Replace("**NAME**", args[1]);
            bool loud;
            if (args[2] == "loud")
            {
                loud = true; // understand I don't need to use the booleans here and can just return the values specified in lower if statements, this is just for practice
            }
            else if (args[2] == "quiet")
            {
                loud = false;
            }
            else
            {
                Console.WriteLine("Unexpected argument.  3rd parameter should be formatted as either 'loud' or 'quiet'");
                return;
            }
            if (loud)
            {
                formatted = unformatted.ToUpper();
            }
            else
            {
                formatted = unformatted.ToLower();
            }
            Console.WriteLine(formatted);
        }
        if (args.Length > 3)
        {
            Console.WriteLine("Too many arguments.  Program expects 2 or 3 parameters.");
        }

    }
}
