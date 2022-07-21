// once again using the code lifted straight from the tutorial
// this demonstrates lists - how they can be created (e.g. with an existing array variable, or hardcoded), and the type of operations that can be done (e.g. pushing a value to the end
// of the list using the add command)

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> someInts = new List<int>(); // declares an empty list
        someInts.Add(2);  // the list now has one item in it: {2}
        Console.WriteLine($"someInts[0]: {someInts[0]}"); // first value of list (someInts[0]) should be 2, after the add command added a 2 to the empty list, this should now be first value

        List<int> moreInts = new List<int>() { 2, 3, 4 }; // you can initialize a list when you create it
        Console.WriteLine($"moreInts[0]: {moreInts[0]}"); // first value of list (moreInts[0] should be 2, as this is the first value in the list defined in above line

        string[] colors = "red,blue,yellow,green".Split(','); // an array of 4 strings
        List<string> colorList = new List<string>(colors); // initialize the list from an array
        Console.WriteLine($"colorList[0]: {colorList[0]}"); // first value of list (colorList[0]) should be red, as this is the first value in the colors array that the list is made from
    }
}