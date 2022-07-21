// this program splits the input string into an array, then utilizes the Join method to put it back into a singular string again

using System;

class Program
{
    static void Main()
    {
        string input = "red,blue,yellow,green";
        string[] colors = input.Split(','); // note single quotes, which are used to define literal character (``char``) values

        string output = String.Join(" | ", colors);
        Console.WriteLine(output);
    }
}