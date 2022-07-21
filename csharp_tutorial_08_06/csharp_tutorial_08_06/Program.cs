// Code taken straight from tutorial, aside from renaming i and j to rowIndex and columnIndex respectively, as the tutorial suggests - in order to make clearer what's going on
// pretty basic though, so edits were perhaps unnecessary.

// program first writes the factors on the first row.  Then every row after, it first writes the other factors that make up the first column, then writes the product 

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Multiplication Table:");
        Console.WriteLine("     1  2  3  4  5  6  7  8  9");
        for (int rowIndex = 1; rowIndex < 10; rowIndex++)
        {
            Console.Write($" {rowIndex} ");
            for (int columnIndex = 1; columnIndex < 10; columnIndex++)
            {
                string product = (rowIndex * columnIndex).ToString();
                Console.Write(product.PadLeft(3)); // adds spaces to start of string until length is 3 - so everything lines up correctly in console (will look bad in browser window)
            }
            Console.WriteLine();
        }
    }
}
