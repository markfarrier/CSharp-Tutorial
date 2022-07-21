using System;

class Program
{
    static void Main()
    {
        var currentTime = DateTime.Now; // current time
        var today = DateTime.Today; // current date - time is midnight
        var someDate = new DateTime(2016, 7, 1); // 1 July 2016, midnight
        var someMoment = new DateTime(2016, 7, 1, 8, 0, 0); // 1 July 2016, 08:00.00
        var tomorrow = DateTime.Today.AddDays(1);
        var yesterday = DateTime.Today.AddDays(-1);
        var someDay = DateTime.Parse("7/1/2016");

        Console.WriteLine($"{nameof(currentTime)}: {currentTime}");
        Console.WriteLine($"{nameof(today)}: {today}");
        Console.WriteLine($"{nameof(someDate)}: {someDate}");
        Console.WriteLine($"{nameof(someMoment)}: {someMoment}");
        Console.WriteLine($"{nameof(tomorrow)}: {tomorrow}");
        Console.WriteLine($"{nameof(yesterday)}: {yesterday}");
        Console.WriteLine($"{nameof(someDay)}: {someDay}");
    }
}
