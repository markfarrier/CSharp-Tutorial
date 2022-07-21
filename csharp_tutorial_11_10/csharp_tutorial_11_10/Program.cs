// code lifted from tutorial demonstrating how method overloads can be used to create methods that handle different types of parameters
// therefore making the code more flexable.  In this case, if you need to call a SecondsRemaining method, but you are working with a variety
// of types, it can fed whatever. (or in this case, a DateTime, a string, or a TimeSpan)

using System;

public class Program
{
    public static void Main()
    {
        DateTime end = DateTime.Now.AddSeconds(10);
        string endTimeString = end.ToString();
        TimeSpan timeLeft = end - DateTime.Now;

        Console.WriteLine($"Seconds: {SecondsRemaining(end)}");
        Console.WriteLine($"Seconds: {SecondsRemaining(endTimeString)}");
        Console.WriteLine($"Seconds: {SecondsRemaining(timeLeft)}");
    }

    static int SecondsRemaining(DateTime endTime)
    {
        return SecondsRemaining(endTime - DateTime.Now);
    }

    static int SecondsRemaining(string endTime)
    {
        return SecondsRemaining(DateTime.Parse(endTime));
    }

    static int SecondsRemaining(TimeSpan duration)
    {
        return (int)duration.TotalSeconds;
    }
}