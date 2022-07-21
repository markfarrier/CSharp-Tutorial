// this program utilizes the "split" command to convert a string (which contains a comma-separated list of colours) into an array

using System;

class Program
{
    static void Main()
    {
        string input = "red,blue,yellow,green";
        string[] colors = input.Split(','); // note single quotes, which are used to define literal character (``char``) values

        Console.WriteLine(colors[0]);
        Console.WriteLine(colors[1]);
    }
}