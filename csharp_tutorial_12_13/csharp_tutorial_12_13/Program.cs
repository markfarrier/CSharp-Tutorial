// once again dealing with shapes
// now using polymorphism to do method calls to the base class.  It will call the correct method in the child class if available.

using System;


class Program
{
    static void Main(string[] args)
    {
        var rectangle = new Rectangle();
        rectangle.Height = 5;
        rectangle.Width = 6;
        DisplayShape(rectangle);

        var triangle = new Triangle();
        triangle.Side1 = 3;
        triangle.Side2 = 4;
        triangle.Side3 = 5;
        DisplayShape(triangle);
    }
    public static void DisplayShape(Shape shape)
    {
        Console.WriteLine($"Shape Perimeter: {shape.Perimeter()}");
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


