// more code from the tutorial
// so if I'm reading the tutorial correctly, the "this" followed by the variable, allows all public variables of that type (in this case "int") within the code to call the Extension Method  
// so when 5.PlusFive() is invoked, because the method is being used on a 5, which is the extension method type, it is allowed to call that extension method with 5 as an input.
// this begs the question how extension methods can have multiple inputs?
// note to self: look into this if tutorial doesn't explain in later sections

using System;

public class Program
{
    public static void Main()
    {
        int ten = 5.PlusFive();
        Console.WriteLine(ten);
    }
}

public static class ExtensionMethods
{
    public static int PlusFive(this int input)
    {
        return input + 5;
    }
}