// code from tutorial demonstrating the use of the "Where" extension method

// where uses a lambda expression as a predicate applied on the list
// new list will only include people over 30 - Steve and Jane

// full explanation of how it works: If the result of the expression is true,
// the current item is added to an an object of type IEnumerable<T>. This new
// IEnumerable<T> will be an "IEnumerable of Person" IEnumerable<Person>,
// because the List it came from was made of Person objects.

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var people = GenerateListOfPeople();

        //There will be two Persons in this variable: the "Steve" Person and the "Jane" Person
        var peopleOverTheAgeOf30 = people.Where(x => x.Age > 30);
        foreach (var person in peopleOverTheAgeOf30)
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