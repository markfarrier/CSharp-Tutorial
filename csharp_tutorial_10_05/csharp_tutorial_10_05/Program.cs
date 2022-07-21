// program that takes a list of numbers, iterates through the list utilizing a for loop and List.Count, printing each number, updating the sum, then printing the sum

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var numbersList = new List<int>() { 2, 4, 6 };
        int sum = 0;
        Console.Write("Numbers:");
        for (int i = 0; i < numbersList.Count; i++)
        {
            Console.Write($" {numbersList[i]}");
            sum += numbersList[i];
        }
        Console.Write($"\nSum: {sum}");
    }
}
