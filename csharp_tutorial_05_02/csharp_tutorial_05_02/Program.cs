using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("TEST ONE:");
        bool someCondition = false; // try it with both true and false values

        var sum = 10;
        if (someCondition)
        {
            sum = sum + 5;
            sum = sum * 2;
        }
        Console.WriteLine(sum); // should output 10 since the if statement is false

        Console.WriteLine("TEST TWO:");
        someCondition = true; // switching to true now for second test
        sum = 10; // resetting sum back to 10
        if (someCondition)
        {
            sum = sum + 5;
            sum = sum * 2;
        }
        Console.WriteLine(sum); // should output 30 now that the if statement is true
    }
}