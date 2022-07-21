// code demonstrating the SingleOrDefault method
// works like FirstOrDefault, but if there's more than 1 result meeting criteria it will throw an exception
// it is expecting only one occurance
// likewise there's a "Single" method that throws an exception if the collection is empty

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var people = GenerateListOfPeople();

        Person single = people.SingleOrDefault(x => x.FirstName == "Eric");
        Console.WriteLine(single.FirstName);
        // Uncomment the next line to see it throw an exception
        // Person singleDev = people.SingleOrDefault(x => x.Occupation == "Dev");
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