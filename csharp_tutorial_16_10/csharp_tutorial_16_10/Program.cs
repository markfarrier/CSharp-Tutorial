// code demonstrating the "LastOrDefault" method which works the same way as "FirstOrDefault" except returns the last element (or last element meeting criteria)
// likewise, there's a "Last" method that throws an exception on an empty collection instead of returning default/null

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var people = GenerateListOfPeople();

        Person lastOrDefault = people.LastOrDefault();
        Console.WriteLine(lastOrDefault.FirstName);
        Person lastThirtyYearOld = people.LastOrDefault(x => x.Age == 30);
        Console.WriteLine(lastThirtyYearOld.FirstName);
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