// another simple program, utilizing foreach, this time printing out every argument parsed into the program

using System;


class Program
{
    static void Main(string[] args)
    {
        foreach (var arg in args)
        {
            Console.WriteLine(arg);
        }
    }
}
