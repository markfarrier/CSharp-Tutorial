// copying code from previous section to test constructors.  This one is parameterless.

// I have added an additional test to see if the fields get cleared after instantializing the class again.  My expectation is that it should.
// after testing, it does.  And it also clears the fields if you simply use the default constructor.

using System;


class Program
{
    static void Main(string[] args)
    {
        var human = new Person();
        Console.WriteLine($"Program started.  First Name is {human.FirstName}.  Last Name is {human.LastName}.  Date Of Birth is {human.DateOfBirth}.  Tax Payer ID = {human.TaxPayerId}");
        human.FirstName = "Barry";
        Console.WriteLine($"Only first name set.  First Name is {human.FirstName}.  Last Name is {human.LastName}.  Date Of Birth is {human.DateOfBirth}.  Tax Payer ID = {human.TaxPayerId}");
        human.LastName = "Falchoner";
        human.DateOfBirth = new DateTime(1986, 6, 6);
        human.TaxPayerId = "123456789";
        Console.WriteLine($"Rest of the fields are now set.  First Name is {human.FirstName}.  Last Name is {human.LastName}.  Date Of Birth is {human.DateOfBirth}.  Tax Payer ID = {human.TaxPayerId}");
        human.FirstName = "Micheal";
        Console.WriteLine($"First Name updated.  First Name is {human.FirstName}.  Last Name is {human.LastName}.  Date Of Birth is {human.DateOfBirth}.  Tax Payer ID = {human.TaxPayerId}");

        human = new Person();
        Console.WriteLine($"New instance of the person class.  First Name is {human.FirstName}.  Last Name is {human.LastName}.  Date Of Birth is {human.DateOfBirth}.  Tax Payer ID = {human.TaxPayerId}");
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string TaxPayerId { get; set; }

    public Person() // this is a method within the Person class
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        TaxPayerId = string.Empty;
    }
}