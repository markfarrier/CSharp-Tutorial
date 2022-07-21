using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"TEST ONE: x=3 y=3 returns value of: {xyComparison(3, 3)}");
        Console.WriteLine($"TEST TWO: x=3 y=4 returns value of: {xyComparison(3, 4)}");
        Console.WriteLine($"TEST THREE: x=4 y=3 returns value of: {xyComparison(4, 3)}");
    }
    static int xyComparison(int x, int y)
    {
        if (x < y)
        {
            return -1;
        }
        else
        {
            if (x == y)
            {
                return 0;
            }
            else // x must be greater than y
            {
                return 1;
            }
        }
    }
}

