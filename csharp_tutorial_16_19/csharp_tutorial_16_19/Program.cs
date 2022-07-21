// last program in tutorial
// requirements: Starting with the Person class and the collection you used in this lesson,
// create a program that prints the name of each developer older than a specified age.
// Prompt the user with the Console.ReadLine() method to determine the age to use for filtering the collection.

// Once you get that working, try adding more people to the collection and filtering based on names instead of ages.

// note: program expects valid integer for age input

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var people = GenerateListOfPeople();

        Console.WriteLine("TEST ONE. Filtering by age");
        Console.WriteLine($"Select minimum age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Developers above the age of {age}");
        foreach (var person in people.Where((x => x.Age > age && x.Occupation == "Dev")))
		{
            Console.WriteLine($"{person.FirstName} {person.LastName}");
		}


        Console.WriteLine("\nTEST ONE: Filtering by name");
        Console.WriteLine($"Select first name: ");
        string name = Console.ReadLine(); // use "Brendan" for most illuminating test results
        people.Add(new Person { FirstName = "Brendan", LastName = "Samson", Occupation = "Dev", Age = 30 });
        people.Add(new Person { FirstName = "Brendan", LastName = "Black", Occupation = "Manager", Age = 55 });
        Console.WriteLine($"Developers with the first name {name}");
        foreach (var person in people.Where((x => x.FirstName == name && x.Occupation == "Dev")))
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }


        //bool allDevs = people.All(x => x.Occupation == "Dev");
        //Console.WriteLine(allDevs);
        //bool everyoneAtLeastTwentyFour = people.All(x => x.Age >= 24);
        //Console.WriteLine(everyoneAtLeastTwentyFour);
    }

    public static List<Person> GenerateListOfPeople()
    {
        var people = new List<Person>();

        people.Add(new Person { FirstName = "Eric", LastName = "Fleming", Occupation = "Dev", Age = 24 });
        people.Add(new Person { FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 40 });
        people.Add(new Person { FirstName = "Brendan", LastName = "Enrick", Occupation = "Dev", Age = 30 });
        people.Add(new Person { FirstName = "Jane", LastName = "Doe", Occupation = "Dev", Age = 35 });
        people.Add(new Person { FirstName = "Samantha", LastName = "Jones", Occupation = "Dev", Age = 24 });

        return people;
    }
}

