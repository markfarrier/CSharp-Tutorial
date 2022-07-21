// again, code is lifted straight from tutorial
// once again, this is incredibly elementary.  i-- will decrement instead of increment (in the case of i++)

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Countdown started...");
        for (int i = 10; i > 0; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("LIFTOFF!");
    }
}