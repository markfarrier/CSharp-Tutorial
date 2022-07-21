// code taken from last tutorial program csharp_tutorial_16_16

// In this case I have added a ToArray method to demonstrate LINQ's conversion capabilities
// this particular method converts from IEnumerable<T> (the return type of all previous methods in this tutorial section)
// into an Array of the same type as before.

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var people = GenerateListOfPeople();

        bool allDevs = people.All(x => x.Occupation == "Dev");
        Console.WriteLine(allDevs);
        bool everyoneAtLeastTwentyFour = people.All(x => x.Age >= 24);
        Console.WriteLine(everyoneAtLeastTwentyFour);


        Console.WriteLine("\n\nRUNNING ToArray TEST\n");
        Person[] arrayOfDevs = people.Where(x => x.Occupation == "Dev").ToArray(); //This will return a Person[] array
        arrayOfDevs[arrayOfDevs.Length - 1] = new Person { FirstName = "Test", LastName = "Testerson", Occupation = "Dev", Age = 33 };
        foreach (var person in arrayOfDevs)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }
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

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Occupation { get; set; }
    public int Age { get; set; }
}