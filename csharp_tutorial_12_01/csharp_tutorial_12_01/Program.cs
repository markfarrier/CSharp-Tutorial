// code lifted from tutorial demonstrating how to call global variables (requires an instance of the class)
// this answers my questions from the previous excercise csharp_tutorial_11_17, where I tried to use shoppingList
// as a global variable but it did not work.

using System;

public class Program
{
    int versionNumber = 123; // defines a field

    public static void Main()
    {
        // the following line will not compile - comment out to fix
 //       Console.WriteLine($"Current version: {versionNumber}");

        // instead, you must create an instance of Program
        var myProgram = new Program();
        Console.WriteLine($"Current version: {myProgram.versionNumber}");
    }
}