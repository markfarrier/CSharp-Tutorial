// using code from the tutorial.  This is the first program from this tutorial section.  In this case, a ToString method is defined to print the message containing the versionnumber
// The first writeline calls myProgram.ToString, which should use the override function
// The second writeline does not have the ToString, but simply myProgram.  It will automatically try and call a ToString function, and will also use the override function.

using System;

public class Program
{
    int versionNumber = 123; // defines a field

    public static void Main()
    {
        var myProgram = new Program();
        Console.WriteLine(myProgram.ToString());
        // or
        // WriteLine will automatically call ToString for you internally
        Console.WriteLine(myProgram);
    }

    public override string ToString()
    {
        return $"MyProgramName - Version {versionNumber}";
    }
}