// this is the same code as the last one, but I have changed the parameter type of the int GetValue method to expect an integer.
// with these methods now unique, the program should compile


using System;

public class Program
{
    public static void Main()
    {
        // this program will now compile, but won't do anything
    }

    string GetValue(string fileName)
    {
        return "";
    }

    int GetValue(int versionNumber)
    {
        return 0;
    }
}