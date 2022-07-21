// code from tutorial showing that if you put a class where a string is expected, it will automatically call the ToString method, which works on all objects\
// in this case, ToString will output the name of the class
// being that this works with/without adding in the ToString, the code below will write the line "Program" twice

// if ToString is defined within the class, it will override this default behaviour

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
}