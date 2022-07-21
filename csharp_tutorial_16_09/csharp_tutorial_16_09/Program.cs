// code demonstrating what happens if the queried data is empty (returns default - which will probably be null)

// this program outputs "true" twice, as it prints two checks that the expected null data (as a result of firstOrDefault being used on an empty collection) is actually null

// there's a "First" method (as opposed to FirstOrDefault) that won't return a default/null, but instead throw an exception if used on an empty collection


using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<Person> emptyList = new List<Person>();
        Person willBeNull = emptyList.FirstOrDefault();

        List<Person> people = GenerateListOfPeople();
        Person willAlsoBeNull = people.FirstOrDefault(x => x.FirstName == "John");

        Console.WriteLine(willBeNull == null); // true
        Console.WriteLine(willAlsoBeNull == null); //true
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