// adding to previous code to demonstrate how people.Any() is probably a cleaner way of checking for an empty list than Count

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var people = GenerateListOfPeople();
        var emptyList = new List<Person>();

        bool thereArePeople = people.Any();
        Console.WriteLine(thereArePeople);
        bool thereAreNoPeople = emptyList.Any();
        Console.WriteLine(thereAreNoPeople);

        if (people.Count() > 0) //This works
        {
            Console.WriteLine($"List {nameof(people)} is NOT empty");
        }
		else
		{
            Console.WriteLine($"List {nameof(people)} is empty");
        }
        if (people.Any()) //This is better
        {
            Console.WriteLine($"List {nameof(people)} is NOT empty");
        }
        else
		{
            Console.WriteLine($"List {nameof(people)} is empty");

        }
        if (emptyList.Count() > 0) //This works
        {
            Console.WriteLine($"List {nameof(emptyList)} is NOT empty");
        }
        else
        {
            Console.WriteLine($"List {nameof(emptyList)} is empty");

        }
        if (emptyList.Any()) //This is better
        {
            Console.WriteLine($"List {nameof(emptyList)} is NOT empty");
        }
        else
		{
            Console.WriteLine($"List {nameof(emptyList)} is empty");

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