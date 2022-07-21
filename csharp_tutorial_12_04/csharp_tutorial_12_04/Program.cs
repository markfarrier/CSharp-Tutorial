// program utilizing the properties feature that allow the usage of get and set methods to update the state of a field
// this acheives the same function as the method calls in the previous program

using System;


class Program
{
    static void Main(string[] args)
    {
        var smeter = new Speedometer();
        Console.WriteLine($"Program started.  No speed set.  Current speed is {smeter.CurrentSpeed}");
        smeter.CurrentSpeed = 20;
        Console.WriteLine($"Speed set to 20.  Current speed is {smeter.CurrentSpeed}");
        smeter.CurrentSpeed = 100;
        Console.WriteLine($"Speed set to 100.  Current speed is {smeter.CurrentSpeed}");
        smeter.CurrentSpeed = 120;
        Console.WriteLine($"Speed set to 120.  Current speed is {smeter.CurrentSpeed}");
        smeter.CurrentSpeed = 0;
        Console.WriteLine($"Speed set to 0.  Current speed is {smeter.CurrentSpeed}");
        smeter.CurrentSpeed = 60;
        Console.WriteLine($"Speed set to 60.  Current speed is {smeter.CurrentSpeed}");
        smeter.CurrentSpeed = -20;
        Console.WriteLine($"Speed set to -20.  Current speed is {smeter.CurrentSpeed}");
        smeter.CurrentSpeed = 200;
        Console.WriteLine($"Speed set to 200.  Current speed is {smeter.CurrentSpeed}");
    }
}

public class Speedometer
{
    private int _currentSpeed;
    public int CurrentSpeed
    {
        get
        {
            return _currentSpeed;
        }
        set
        {
            if (value < 0) return;
            if (value > 120) return;

            // value is a keyword used in setters representing the new value
            _currentSpeed = value;
        }
    }
}