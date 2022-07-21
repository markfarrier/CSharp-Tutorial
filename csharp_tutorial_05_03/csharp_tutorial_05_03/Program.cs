using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is the capital of Ohio?");
        var answer = "I have no idea."; // change this to your answer
        if (answer.ToLower() == "columbus")
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Sorry, that's not the right answer.");
        }
    }
}