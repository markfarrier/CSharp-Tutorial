using System;

// untested, but this solution should handle any issues with leap years
// less elegant than divind TimeSpan difference by 365, but more accurate
// perhaps a bit of a hacky solution.  Probably a better way to do it but it works.

// previous iteration had a mess of conditional logic with an if statement working out whether today's month is
// birth month, and then what day of month it is compared to birth day - in order to resolve the issues with leap years.
// But DayOfYear property allows for a much more elegant solution.  However, there are perhaps other solutions that
// might be more elegant.  This one is accurate though.

// I'm using if statements here.  Which haven't been covered in the tutorial yet.  So I wonder if there's a
// more obvious solution to handling the leap year issue, if they don't expect the person following the tutorial
// to know about if statements yet.

class Program
{
    static void Main()
    {
        int bday = 8;
        int bmonth = 4;
        int byear = 1986;

        Console.WriteLine($"Age is {age(bday, bmonth, byear)}");
        Console.WriteLine($"Date of next 10k Anniversary is: {(dateOf10kAnniversary(bday, bmonth, byear)).ToString()}"); // this returns the time of midnight too.
        // unsure if time information is unnecessary.  Could equally be done without the ToString method, but might take more code.  Could possibly truncate the string as a solution.
        // or maybe just get the day month and year individually.

    }
    private static int age(int birthDay, int birthMonth, int birthYear)
    {
        DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
        DateTime todayDate = DateTime.Today;
        int todayYear = todayDate.Year;
        int birthDayOfYear = birthDate.DayOfYear; // utilizing dayOfYear should resolve any issues with leap years 
        int todayDayOfYear = todayDate.DayOfYear;
        int result = (todayYear - birthYear); // age starts at the difference in years, but one is subtracted in next line...
        if (todayDayOfYear<birthDayOfYear) // ...if it hasn't been your birthday yet this year
        {
            result--;
        }
        return result;
    }
    
    private static DateTime dateOf10kAnniversary(int birthDay, int birthMonth, int birthYear) // figured I'd make the extra credit thing it's own method, using the same parameters
        // returns a DateTime, as it's afterall, a date, so it's the appropriate thing for the method to return
    {
        DateTime date = new DateTime();
        DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
        DateTime todayDate = DateTime.Today;
        int AgeInDays = Convert.ToInt32(Math.Floor((todayDate - birthDate).TotalDays));
        int daysToNextAnniversary = 10000 - (AgeInDays % 10000); // using the code from the note in the tutorial.
        date = todayDate.AddDays(daysToNextAnniversary);
        return date;
    }
}
