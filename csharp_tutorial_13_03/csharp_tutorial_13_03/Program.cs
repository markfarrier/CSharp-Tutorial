// this code demonstrates method scoping
// the first method (aside from main) will allow the program to compile due to the fact that all the variables are created within the method and are called after creation
// the second method will prevent the program from compiling because the width and length variables are called before they are created within the method
// the third method will prevent the program from compiling because the width and length variables aren't even created in the method at all

// despite the fact that the variables are defined in the first method and the first method is run before the other two, new instances of these variables must be created
// as they don't exist outside the scope of the first method

// the method calls and the methods themselves need to be commented out for this program to run
// either that or modified such that width and length are actually created within the method and before they are used

using System;

public class Program
{
    public static void Main()
    {
        DoesCompile();
        DoesNotCompile();
        AlsoDoesNotCompile();
    }
    public static void DoesCompile()
    {
        int width = 10;
        int length = 4;
        int area = width * length;
        Console.WriteLine($"{nameof(area)}:{area}");
    }
    public static void DoesNotCompile()
    {
        int area = width * length; // width and length don't exist yet
        int width = 10;
        int length = 4;
        Console.WriteLine($"{nameof(area)}:{area}");
    }
    public static void AlsoDoesNotCompile()
    {
        int area = width * length; // width and length not in this method
        Console.WriteLine($"{nameof(area)}:{area}");
    }
}