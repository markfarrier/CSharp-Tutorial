// copying code from previous section to test constructors.  This one now has parameters.

// the addition of the parametered constructor, without any parameterless constructors, means that the class can no longer be constructed without parameters
// a parameterless constructor can be added alongside if necessary.

using System;


class Program
{
    static void Main(string[] args)
    {
        //        var human = new Person(); // program will not compile if this isn't commented out, as it is trying to initialize a new instance of a Person class without any parameters.
        // the existence of the parametered constructor and lack of a parameterless constructor means this cannot be done
        var human = new Person(new DateTime(1983, 3, 3));
        Console.WriteLine($"Program started.  First Name is {human.FirstName}.  Last Name is {human.LastName}.  Date Of Birth is {human.DateOfBirth}.  Tax Payer ID = {human.TaxPayerId}");
        human.FirstName = "Barry";
        Console.WriteLine($"Only first name set.  First Name is {human.FirstName}.  Last Name is {human.LastName}.  Date Of Birth is {human.DateOfBirth}.  Tax Payer ID = {human.TaxPayerId}");
        human.LastName = "Falchoner";
        human.DateOfBirth = new DateTime(1986, 6, 6);
        human.TaxPayerId = "123456789";
        Console.WriteLine($"Rest of the fields are now set.  First Name is {human.FirstName}.  Last Name is {human.LastName}.  Date Of Birth is {human.DateOfBirth}.  Tax Payer ID = {human.TaxPayerId}");
        human.FirstName = "Micheal";
        Console.WriteLine($"First Name updated.  First Name is {human.FirstName}.  Last Name is {human.LastName}.  Date Of Birth is {human.DateOfBirth}.  Tax Payer ID = {human.TaxPayerId}");

        //   human = new Person();
        human = new Person(new DateTime(1999, 9, 9));
        Console.WriteLine($"New instance of the person class.  First Name is {human.FirstName}.  Last Name is {human.LastName}.  Date Of Birth is {human.DateOfBirth}.  Tax Payer ID = {human.TaxPayerId}");
    }
}

public class Person
{
    public Person(DateTime dateOfBirth)
    {
        DateOfBirth = dateOfBirth;
    }


    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public string TaxPayerId { get; set; } = string.Empty;
}