﻿// code demonstrating how LINQ can return individual items rather than collections

// in this case we're using the FirstOrDefault extension method to output the first element of the collection.
// if there's no elements, it will return the default value type for the object, which is usually null.

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var people = GenerateListOfPeople();

        Person firstOrDefault = people.FirstOrDefault();
        Console.WriteLine(firstOrDefault.FirstName);
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