using System;

class Program
{
    static void Main()
    {
        DateTime birthDate = new DateTime(1986, 4, 8);
        TimeSpan elapsedTime = DateTime.Today - birthDate;
        int age = Convert.ToInt32(Math.Floor((elapsedTime.TotalDays)/365.25));
        Console.WriteLine($"Age is {age}");
    }
}

// this is a lazy way of doing it.  I'm guessing it might be incorrect in certain cases however.
// extra credit is in next section, as well as a certainly accurate version