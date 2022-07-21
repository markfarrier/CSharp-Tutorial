// this program demonstrates the fact that the integer i variable created in the for loop only exists within the scope of that loop
// therefore trying to call "i" outside of the loop will render the program uncompilable

using System;

public class Program
{
    public static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        // Try uncommenting this WriteLine - it won't compile
        //Console.WriteLine(i);
    }
}