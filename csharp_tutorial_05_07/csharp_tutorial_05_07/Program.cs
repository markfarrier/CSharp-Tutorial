using System;

class Program
{
    static void Main()
    {
        uint guessedNumber = 0; // try different numbers to see resulting behavior
        for (uint i = guessedNumber; i < 10; i++)
        {
            Console.WriteLine($"TEST {i+1}: guessedNumber = {i}");
            switchTest(i);
        }

    }
    static void switchTest(uint guessedNumber)
    {
        switch (guessedNumber)
        {
            case 0:
                Console.WriteLine("Sorry, 0 is not a valid guess.");
                break;
            case 1:
            case 2:
            case 3:
                Console.WriteLine("You guessed low.");
                break;
            case 4:
                Console.WriteLine("You guessed the right number!");
                break;
            default:
                Console.WriteLine("You guessed high.");
                break;
        }
    }


}