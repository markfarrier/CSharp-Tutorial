// a method can contain only one object of a given name

// if i is used outside the for loop and within the method, it can't be used in the for loop
// if you comment out the last two lines, you could still use i again for a second for loop
// due to the fact that in this case i doesn't exist out of the scope of the loop
// in this example however, i exists outside the scope of the loop within the parent block
// therefore it cannot be created within the loop aswell

using System;

public class Program
{
    public static void Main()
    {
        DoWork();
    }
    public static void DoWork()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        
        int i = 777; // Compiler error here
        Console.WriteLine(i);
    }
}