// this is the same code from csharp_tutorial_12_10, but I have now made the shape class abstract

// I no longer can instantiate an instance of shape, but classes can still inherit from it

// unlike the previous shape program where a non-abstract class, and virtual method, is used - the methods in the inherited class MUST contain the override keyword for this code to function

using System;


class Program
{
    static void Main(string[] args)
    {
   //     var shape = new Shape();
    //    Console.WriteLine($"SHAPE perimeter = {shape.Perimeter()}");
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

public abstract class Shape
{
    public abstract int Perimeter();
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