// code copied from tutorial.  Incredibly straight-forward what it's doing.  I could iterate through them like I did in last project, but it's unnecessary.

using System;

class Program
{
    static void Main()
    {
        int[,] eggCarton = new int[2, 6]; // a typical egg carton can be thought of as a 2x6 array
        Console.WriteLine(eggCarton[0, 0]); // one "corner" of the array
        Console.WriteLine(eggCarton[1, 5]); // the opposite "corner"

        int[,] someTable = { { 1, 2, 3 }, { 4, 5, 6 } }; // you can fill a multi-dimensional array on assignment as well
        Console.WriteLine(someTable[0, 0]); // one "corner" of the array
        Console.WriteLine(someTable[1, 2]); // the opposite "corner"
    }
}