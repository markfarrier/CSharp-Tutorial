using System;

class Program
{
    static void Main(string[] args)
    {
        var now = DateTime.Now; // defining this here as now is used not just singularly (would otherwise do away with defining the now variable)
        int hour = now.Hour;
        Console.WriteLine($"The current time is {now.TimeOfDay.ToString()}"); // probably doesn't need to be accurate to fraction of seconds, but this part isn't necessary anyway.  Just for testing.
        // unsure if switch allows for date ranges, rather than singular "cases" of a variable, so proceeding with if/else statements
        if (hour >= 0 && hour < 24) // checking to make sure hour is a valid value, although this is unnecessary as DateTime.Hour should only return values in the range of 0-23 anyway
        {
            if (hour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (hour < 17) // could use and operators to make sure hour is also >= 12, but the "else if" expression renders this unnecessary as this condition is already built into the expression
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (hour < 20) // unsure of what the exact cutoff between afternoon/evening/night should be - but I guess it doesn't really matter.
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Night");

            }
        }
        else
        {
            Console.WriteLine("Invalid Time.");
        }
    }
}