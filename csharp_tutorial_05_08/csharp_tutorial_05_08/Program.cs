// as stated in tutorial: For this exercise, assume the user will only enter valid guesses
// therefore only accepts int guesses or else an exception will occur

using System;
class Program
{
    static void Main()
    {
        int correctNumber = new Random().Next(3) + 1;
        Console.WriteLine($"SPOILER ALERT: Correct Number is {correctNumber}");
        int guessedNumber;
        while (true)
        {
            Console.WriteLine("GUESS THE NUMBER!:");
            guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber == correctNumber)
            {
                Console.WriteLine($"CORRECT!");
                return;
            }
            else
            {
                Console.WriteLine("WRONG!\n");
            }
        }
    }
}

