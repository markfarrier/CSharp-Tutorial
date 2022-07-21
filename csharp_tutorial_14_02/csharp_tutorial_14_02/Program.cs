// this technically isn't part of the github tutorial, but I was having trouble understanding the behaviour in the previous program
// I was directed to an explanation on reference and data types, which clears up this confusion
// here we have an example of a value type.  Despite the fact that p2 is created from p1, it's contents are copied rather than a reference made.
// therefore changes to p2 will not effect p1 even if the program isn't sufficiently encapsulated to prevent changes to p1
// when p2 is passed into MutateAndDisplay, it appears to copy it's value onto a new instance, as while the X variable is changed within
// the MutateAndDisplay method, it reverts to its previous value when p2 is called outside this method.

using System;

public struct MutablePoint
{
    public int X;
    public int Y;

    public MutablePoint(int x, int y) => (X, Y) = (x, y);

    public override string ToString() => $"({X}, {Y})";
}

public class Program
{
    public static void Main()
    {
        var p1 = new MutablePoint(1, 2);
        var p2 = p1;
        p2.Y = 200;
        Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified: {p1}");
        Console.WriteLine($"{nameof(p2)}: {p2}");

        MutateAndDisplay(p2);
        Console.WriteLine($"{nameof(p2)} after passing to a method: {p2}");
    }

    private static void MutateAndDisplay(MutablePoint p)
    {
        p.X = 100;
        Console.WriteLine($"Point mutated in a method: {p}");
    }
}
// Expected output:
// p1 after p2 is modified: (1, 2)
// p2: (1, 200)
// Point mutated in a method: (100, 200)
// p2 after passing to a method: (1, 200)
