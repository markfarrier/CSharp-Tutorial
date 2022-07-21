// program demonstrating inheritence.  The virtual method in Shape can be overridden by classes that inherit Shape using the override keyword.

// tutorial says "Requiring the use of the override keyword ensures that developers do not accidentally override base class behavior."
// however, removing the override keyword does not change the output of this program. (it doesn't try to call the Shape.Perimeter when dealing with Rectangle or Triangle.

// something to note: C# does not support multiple inheritence.  If this is required, composition can be used instead.

using System;


class Program
{
    static void Main(string[] args)
    {
        var shape = new Shape();
        Console.WriteLine($"SHAPE perimeter = {shape.Perimeter()}");
        var rectangle = new Rectangle();
        Console.WriteLine($"RECTANGLE perimeter = {rectangle.Perimeter()}");
        var triangle = new Triangle();
        Console.WriteLine($"TRIANGLE perimeter = {triangle.Perimeter()}");
        Console.WriteLine("\nSetting dimensions.\n");
        rectangle.Height = 6;
        rectangle.Width = 7;
        triangle.Side1 = 3; // figured I should make it a legal triangle even though the code doesn't check for it or care
        triangle.Side2 = 4;
        triangle.Side3 = 5;
        Console.WriteLine($"RECTANGLE perimeter = {rectangle.Perimeter()}");
        Console.WriteLine($"TRIANGLE perimeter = {triangle.Perimeter()}");
    }
}

public class Shape
{
    public virtual int Perimeter()
    {
        return 0;
    }
}
public class Rectangle : Shape
{
    public int Height { get; set; }
    public int Width { get; set; }

    public override int Perimeter()
    {
        return (Height + Width) * 2;
    }
}
public class Triangle : Shape
{
    public int Side1 { get; set; }
    public int Side2 { get; set; }
    public int Side3 { get; set; }

    public override int Perimeter()
    {
        return Side1 + Side2 + Side3;
    }
}