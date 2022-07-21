// this program demonstrates that when using class level scoping, the order of in which objects are declared doesn't matter - unlike with method or block scoping
// in this example the method Circle(decimal radius) references a Radius field, which has not yet been defined within the class.
// likewise, the method Perimiter() references the _pi field, which has also not yet been defined within the class

// with method and block scoping, radius and pi would need to be defined before being referenced.
// in class level scoping, this ordering is not required.  If it exists within the class, it exists, as long as the class object has been instantiated. (and is available for the lifetime of this object instance)
// Whereas in a method or block, it must first execute the operation declaring the variable in order for that variable to exist and be able to be used.

using System;

public class Program
{
    public static void Main()
    {
        var circle = new Circle(5m);
        Console.WriteLine(circle.Perimeter());
    }
}

public class Circle
{
    public Circle(decimal radius)
    {
        Radius = radius; // Using Radius before it's declared
    }

    public decimal Radius { get; private set; }

    public decimal Perimeter()
    {
        return 2 * _pi * this.Radius; // Using _pi before it's declared
    }

    private const decimal _pi = 3.14159m;
}