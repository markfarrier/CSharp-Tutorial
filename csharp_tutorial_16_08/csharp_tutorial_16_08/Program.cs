// code demonstating how FirstOrDefault could be used to filter a list to return the first element meeting a criteria
// first example puts the criteria within the FirstOrDefault method
// second example combines Where and FirstOrDefault.  Where imposes the criteria and FirstOrDefault finds the first item meeting this criteria
// both return the same results
// the use of Where is unnecessary here

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var people = GenerateListOfPeople();

        var firstThirtyYearOld1 = people.FirstOrDefault(x => x.Age == 30);
        var firstThirtyYearOld2 = people.Where(x => x.Age == 30).FirstOrDefault();
        Console.WriteLine(firstThirtyYearOld1.FirstName); //Will output "Brendan"
        Console.WriteLine(firstThirtyYearOld2.FirstName); //Will also output "Brendan"
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