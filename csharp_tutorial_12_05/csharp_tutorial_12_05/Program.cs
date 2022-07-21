// program demonstrating how simple properties can be if they don't need to perform additional behaviour in the get/set

// something to note: the DateTime has a default value before it is set, whereas the rest will simply be empty strings.

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
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string TaxPayerId { get; set; }
}