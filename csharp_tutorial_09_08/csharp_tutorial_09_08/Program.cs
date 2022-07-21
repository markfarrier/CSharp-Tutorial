// similar to iterating through every element an array (e.g. using a for loop), this program utilizes the ForEach method to write out every element in the list

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var colors = new List<string>() { "blue", "green", "yellow" };
        colors.ForEach(Console.WriteLine); // equivalent to ForEach(c => Console.WriteLine(c)) 
    }
}