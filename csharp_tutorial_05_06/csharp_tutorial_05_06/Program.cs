// hacky solution, more elegant solution in next project

using System;

class Program
{
    static void Main()
    {
        uint guessedNumber = 0; // try different numbers to see resulting behavior
        Console.WriteLine("TEST ONE: guessedNumber = 0");
        switchTest(guessedNumber);
        guessedNumber++;
        Console.WriteLine("TEST TWO: guessedNumber = 1");
        switchTest(guessedNumber);
        guessedNumber++;
        Console.WriteLine("TEST THREE: guessedNumber = 2");
        switchTest(guessedNumber);

        guessedNumber++;
        Console.WriteLine("TEST FOUR: guessedNumber = 3");
        switchTest(guessedNumber);

        guessedNumber++;
        Console.WriteLine("TEST FIVE: guessedNumber = 4");
        switchTest(guessedNumber);

        guessedNumber++;
        Console.WriteLine("TEST SIX: guessedNumber = 5");
        switchTest(guessedNumber);

        guessedNumber++;
        Console.WriteLine("TEST SEVEN: guessedNumber = 6");
        switchTest(guessedNumber);

        guessedNumber++;
        Console.WriteLine("TEST EIGHT: guessedNumber = 7");
        switchTest(guessedNumber);

        guessedNumber++;
        Console.WriteLine("TEST NINE: guessedNumber = 8");
        switchTest(guessedNumber);

        guessedNumber++;
        Console.WriteLine("TEST TEN: guessedNumber = 9");
        switchTest(guessedNumber);

        // a for loop iterating through these things would also acheive the same result more elegantly, but in terms of expediating a solution I figured I'd do it this way first
        // will do a for loop in next one csharp_tutorial_05_07

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