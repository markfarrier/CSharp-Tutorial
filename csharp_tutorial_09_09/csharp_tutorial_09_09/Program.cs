// instead of looping through the list utilizing the ForEach command, this program utilizes the join method to write out the list, this time separated with commas rather than line breaks

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var colors = new List<string>() { "blue", "green", "yellow" };
        Console.WriteLine(String.Join(",", colors));
    }
}