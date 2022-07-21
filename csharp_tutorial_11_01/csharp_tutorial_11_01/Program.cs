using System;

public class Program
{
    static void Main()
    {
        var name = new Name();
        name.FirstName = "Mark"; // I figured I would define the names within the Main method rather than hardcode it into the class.  Could equally ask for user input.
        name.LastName = "Farrier";
        Console.WriteLine($"TESTING ADD METHOD with 2 and 3 as parameters:\nResults =  {Add(2, 3)}");
        Console.WriteLine($"TESTING FULLNAME METHOD:\nResults = {name.FullName()}");
    }

    static int Add(int operand1, int operand2)
    {
        // only works with its own parameters; works well as static method
        return operand1 + operand2;
    }
}

public class Name
{
    public string FirstName;
    public string LastName;
    public string FullName()
    {
        // FirstName and LastName are Properties of this class - shouldn't be static
        return $"{FirstName} {LastName}";
    }


}

