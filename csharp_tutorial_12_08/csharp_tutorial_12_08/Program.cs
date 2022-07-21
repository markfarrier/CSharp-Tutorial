// this program isn't demonstrating anything new, but the next program will demonstrate an alternate approach that uses composition to create cleaner code

using System;

class Program
{
    static void Main(string[] args)
    {
        var human = new Person();
        var company = new Company();
        Console.WriteLine($"Program started.\n\nPERSON:\n\nFirst Name = {human.FirstName}\nLast Name = {human.LastName}\nStreet Address = {human.StreetAddress}\nCity = {human.City}\nState = {human.State}\nPostal Code = {human.PostalCode}\nCountry = {human.Country}\n\nCOMPANY\n\nName = {company.Name}\nStreet Address = {company.StreetAddress}\nCity = {company.City}\nState = {company.State}\nPostal Code = {company.PostalCode}\nCountry = {company.Country}\n\n\n");
        human.FirstName = "Richard";
        human.LastName = "Richardson";
        human.StreetAddress = "101 Richard Way";
        human.City = "Richardtown";
        human.State = "RIC";
        human.PostalCode = "1000";
        human.Country = "Richardland";
        company.Name = "Business Inc.";
        company.StreetAddress = "40 Business Lane";
        company.City = "Business Town";
        company.State = "BIZ";
        company.PostalCode = "2000";
        company.Country = "Businessland";
        Console.WriteLine($"Fields updated.\n\nPERSON:\n\nFirst Name = {human.FirstName}\nLast Name = {human.LastName}\nStreet Address = {human.StreetAddress}\nCity = {human.City}\nState = {human.State}\nPostal Code = {human.PostalCode}\nCountry = {human.Country}\n\nCOMPANY\n\nName = {company.Name}\nStreet Address = {company.StreetAddress}\nCity = {company.City}\nState = {company.State}\nPostal Code = {company.PostalCode}\nCountry = {company.Country}\n\n\n");
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
}
public class Company
{
    public string Name { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
}