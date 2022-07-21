// as commented within the code, this program won't compile.  This is because there are two methods with the same name, that accept the same parameters. (a string)
// Even though they do not return the same type this is disallowed, presumably because if the GetValue method was called, it wouldn't know which method to call or type to return

using System;

public class Program
{
    public static void Main()
    {
        // this program won't compile
    }

    string GetValue(string fileName)
    {
        return "";
    }

    int GetValue(string versionNumber)
    {
        return 0;
    }
}