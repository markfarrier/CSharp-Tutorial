// this program does the same thing as the previous one, except it is split into separate methods (one displaying the header, and one displaying the menu) and executed via method calls instead of
// having the writelines hardcoded inside the main method

using System;

public class Program
{
    public static void Main()
    {
        DisplayHeader();
        DisplayMenu();

        // additional code omitted

    }

    static void DisplayHeader()
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("**** My Super Program *******************");
        Console.WriteLine("-----------------------------------------");
    }

    static void DisplayMenu()
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1 - View the Menu");
        Console.WriteLine("2 - Exit the Program");
    }
}