using System;

class Program
{
    static void Main()
    {
        DateTime nextYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
        TimeSpan duration = nextYear - DateTime.Today;
        Console.WriteLine($"There are {duration.TotalDays} days left in the year");
    }
}
