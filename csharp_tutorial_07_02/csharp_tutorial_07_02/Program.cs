// same as last one, except instead of adding the "is it equal" condition to the while loop, I'm doing a while(true) and relying on an if statement (checking equality) within the loop
// to break out of the loop when the guess becomes correct

using System;

class Program
{
    static void Main()
    {
        int numberToGuess = new Random().Next(1, 101); // a number from 1 to 100
        int currentGuess = 0; // start with an incorrect guess
        Console.WriteLine($"SPOILER ALERT: the correct number is {numberToGuess}");
        while (true)
        {
            Console.WriteLine("Guess the number (1 to 100): ");
            currentGuess = int.Parse(Console.ReadLine()); // will crash program if user enters a non-integer
            if (currentGuess == numberToGuess) break;
            if (currentGuess < numberToGuess)
            {
                Console.WriteLine("You guessed too low! Try again!");
            }
            if (currentGuess > numberToGuess)
            {
                Console.WriteLine("You guessed too high! Try again!");
            }
        }
        Console.WriteLine("You got it! Good job!");
    }
}
