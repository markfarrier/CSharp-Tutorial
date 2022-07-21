// code demonstating the "Any" method.  Returns a boolean of true if any elements in collection meet a criteria.  Returns false if none meet the criteria.
// in this case we're not imposing any criteria and the method will instead check if the list is populated at all.
// a populated list will meet the zero criteria
// no elements in an unpopulated list will meet the criteria, as there aren't any elements at all

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