using System;

class Program
{
    static void Main()
    {
        var someTime = new DateTime(2016, 7, 1, 11, 10, 9); // 1 July 2016 11:10:09 AM
        int year = someTime.Year; // 2016
        int month = someTime.Month; // 7
        int day = someTime.Day; // 1
        int hour = someTime.Hour; // 11
        int minute = someTime.Minute; // 10
        int second = someTime.Second; // 9

        Console.WriteLine($"{nameof(someTime)}: {someTime}");
        Console.WriteLine($"{nameof(year)}: {year}");
        Console.WriteLine($"{nameof(month)}: {month}");
        Console.WriteLine($"{nameof(day)}: {day}");
        Console.WriteLine($"{nameof(hour)}: {hour}");
        Console.WriteLine($"{nameof(minute)}: {minute}");
        Console.WriteLine($"{nameof(second)}: {second}");
    }
}