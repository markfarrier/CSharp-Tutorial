// program demonstrating how fields of a class instance can be retrieved and updated via method calls

using System;


class Program
{
    static void Main(string[] args)
    {
        var smeter = new Speedometer();
        Console.WriteLine($"Program started.  No speed set.  Current speed is {smeter.GetCurrentSpeed()}");
        smeter.SetCurrentSpeed(20);
        Console.WriteLine($"Speed set to 20.  Current speed is {smeter.GetCurrentSpeed()}");
        smeter.SetCurrentSpeed(100);
        Console.WriteLine($"Speed set to 100.  Current speed is {smeter.GetCurrentSpeed()}");
        smeter.SetCurrentSpeed(120);
        Console.WriteLine($"Speed set to 120.  Current speed is {smeter.GetCurrentSpeed()}");
        smeter.SetCurrentSpeed(0);
        Console.WriteLine($"Speed set to 0.  Current speed is {smeter.GetCurrentSpeed()}");
        smeter.SetCurrentSpeed(60);
        Console.WriteLine($"Speed set to 60.  Current speed is {smeter.GetCurrentSpeed()}");
        smeter.SetCurrentSpeed(-20);
        Console.WriteLine($"Speed set to -20.  Current speed is {smeter.GetCurrentSpeed()}");
        smeter.SetCurrentSpeed(200);
        Console.WriteLine($"Speed set to 200.  Current speed is {smeter.GetCurrentSpeed()}");
    }
}

public class Speedometer
{
    private int _currentSpeed;
    public int GetCurrentSpeed()
    {
        return _currentSpeed;
    }
    public void SetCurrentSpeed(int newSpeed)
    {
        if (newSpeed < 0) return;
        if (newSpeed > 120) return;

        _currentSpeed = newSpeed;
    }
}