// code demonstrating another use case of Select
// this time we are creating a brand new object based on properties selected, and populating a new collection with these objects
// in this case, we are concatenating first + last names to create a FullName object, and creating a collection of type FullName.

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var people = GenerateListOfPeople();

        IEnumerable<FullName> allFullNames = people.Select(x => new FullName { First = x.FirstName, Last = x.LastName });
        foreach (var fullName in allFullNames)
        {
            Console.WriteLine($"{fullName.Last}, {fullName.First}");
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

public class FullName
{
    public string First { get; set; }
    public string Last { get; set; }
}