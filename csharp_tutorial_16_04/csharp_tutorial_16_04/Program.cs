// code from tutorial demonstrating the "Take" method.
// does the opposite of skip, will return the first x items in the collection rather than a collection discluding first x items.  It will instead disclude everything else.

// note:  apparently you can chain the Skip and Take methods to skip one or more items and take the next ones.

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var people = GenerateListOfPeople();

        //Will only return Eric and Steve from the list of people
        IEnumerable<Person> takeTwo = people.Take(2);
        foreach (var person in takeTwo)
        {
            Console.WriteLine(person.FirstName);
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