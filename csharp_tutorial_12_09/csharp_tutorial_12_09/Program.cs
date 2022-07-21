// this program is modified from the previous program to separate Address into its own class
// this demonstrates composition

using System;

class Program
{
    static void Main(string[] args)
    {
        var human = new Person();
        var company = new Company();
        human.ShippingAddress = new Address(); // creating a new instance of the Person/Company classes do now create instances of the address within.  Therefore these must be instantiated separately otherwise there will be a null reference exception.
        company.ShippingAddress = new Address();
        Console.WriteLine($"Program started.\n\nPERSON:\n\nFirst Name = {human.FirstName}\nLast Name = {human.LastName}\nStreet Address = {human.ShippingAddress.StreetAddress}\nCity = {human.ShippingAddress.City}\nState = {human.ShippingAddress.State}\nPostal Code = {human.ShippingAddress.PostalCode}\nCountry = {human.ShippingAddress.Country}\n\nCOMPANY\n\nName = {company.Name}\nStreet Address = {company.ShippingAddress.StreetAddress}\nCity = {company.ShippingAddress.City}\nState = {company.ShippingAddress.State}\nPostal Code = {company.ShippingAddress.PostalCode}\nCountry = {company.ShippingAddress.Country}\n\n\n");
        human.FirstName = "Richard";
        human.LastName = "Richardson";
        human.ShippingAddress.StreetAddress = "101 Richard Way";
        human.ShippingAddress.City = "Richardtown";
        human.ShippingAddress.State = "RIC";
        human.ShippingAddress.PostalCode = "1000";
        human.ShippingAddress.Country = "Richardland";
        company.Name = "Business Inc.";
        company.ShippingAddress.StreetAddress = "40 Business Lane";
        company.ShippingAddress.City = "Business Town";
        company.ShippingAddress.State = "BIZ";
        company.ShippingAddress.PostalCode = "2000";
        company.ShippingAddress.Country = "Businessland";
        Console.WriteLine($"Fields updated.\n\nPERSON:\n\nFirst Name = {human.FirstName}\nLast Name = {human.LastName}\nStreet Address = {human.ShippingAddress.StreetAddress}\nCity = {human.ShippingAddress.City}\nState = {human.ShippingAddress.State}\nPostal Code = {human.ShippingAddress.PostalCode}\nCountry = {human.ShippingAddress.Country}\n\nCOMPANY\n\nName = {company.Name}\nStreet Address = {company.ShippingAddress.StreetAddress}\nCity = {company.ShippingAddress.City}\nState = {company.ShippingAddress.State}\nPostal Code = {company.ShippingAddress.PostalCode}\nCountry = {company.ShippingAddress.Country}\n\n\n");
    }
}

public class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
}
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Address ShippingAddress { get; set; }
}
public class Company
{
    public string Name { get; set; }
    public Address ShippingAddress { get; set; }
}