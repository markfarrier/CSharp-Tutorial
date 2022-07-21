// this is the final problem in the tutorial, looping through a collection of people and companies and printing out the names + addresses
// tutorial instructed to encapsulate the logic for displaying address information, this has been done via the addressString method
// some further encapsulation was done via the PrintPerson/Company/People/Companies methods.  No attempt was made to reduce the busywork involved
// in setting the values of people/companies as this was not asked for and would require modifying the classes in a way that I'm not sure
// if the tutorial wants me to do.
// e.g. I could easily be setting these values when initializing the instances of Person/Company via parameters
// instead I'm using the basic sets/gets provided to me


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // could probably do all this setting of values differently and with much less busywork, but I was apprehensive to change the methods too much beyond the scope of what was required

        var person1 = new Person();
        var person2 = new Person();
        var person3 = new Person();
        var person4 = new Person();
        var person5 = new Person();

        person1.FirstName = "Mary";
        person2.FirstName = "Mark";
        person3.FirstName = "Matt";
        person4.FirstName = "Micheal";
        person5.FirstName = "Max";

        person1.LastName = "Maryson";
        person2.LastName = "Markson";
        person3.LastName = "Mattson";
        person4.LastName = "Michealson";
        person5.LastName = "Maxson";

        person1.ShippingAddress.StreetAddress = "1 Mary Road";
        person2.ShippingAddress.StreetAddress = "2 Mark Street";
        person3.ShippingAddress.StreetAddress = "3 Matt Lane";
        person4.ShippingAddress.StreetAddress = "4 Micheal Way";
        person5.ShippingAddress.StreetAddress = "5 Max Avenue";

        person1.ShippingAddress.City = "Appletown";
        person2.ShippingAddress.City = "Orangetown";
        person3.ShippingAddress.City = "Bananatown";
        person4.ShippingAddress.City = "Plumtown";
        person5.ShippingAddress.City = "Manderintown";

        person1.ShippingAddress.State = "MRY";
        person2.ShippingAddress.State = "MRK";
        person3.ShippingAddress.State = "MTT";
        person4.ShippingAddress.State = "MIC";
        person5.ShippingAddress.State = "MAX";


        person1.ShippingAddress.PostalCode = "1000";
        person2.ShippingAddress.PostalCode = "2000";
        person3.ShippingAddress.PostalCode = "3000";
        person4.ShippingAddress.PostalCode = "4000";
        person5.ShippingAddress.PostalCode = "5000";

        person1.ShippingAddress.Country = "Maryland";
        person2.ShippingAddress.Country = "Markland";
        person3.ShippingAddress.Country = "Mattland";
        person4.ShippingAddress.Country = "Michealland";
        person5.ShippingAddress.Country = "Maxland";

        var company1 = new Company();
        var company2 = new Company();
        var company3 = new Company();
        var company4 = new Company();
        var company5 = new Company();

        company1.Name = "Apple Inc.";
        company2.Name = "Orange Inc.";
        company3.Name = "Banana Inc.";
        company4.Name = "Plum Inc.";
        company5.Name = "Manderin Inc.";

        company1.ShippingAddress.StreetAddress = "1 Apple Road";
        company2.ShippingAddress.StreetAddress = "2 Orange Street";
        company3.ShippingAddress.StreetAddress = "3 Banana Lane";
        company4.ShippingAddress.StreetAddress = "4 Plum Way";
        company5.ShippingAddress.StreetAddress = "5 Manderin Avenue";

        company1.ShippingAddress.City = "Appletown";
        company2.ShippingAddress.City = "Orangetown";
        company3.ShippingAddress.City = "Bananatown";
        company4.ShippingAddress.City = "Plumtown";
        company5.ShippingAddress.City = "Manderintown";

        company1.ShippingAddress.State = "APP";
        company2.ShippingAddress.State = "ORG";
        company3.ShippingAddress.State = "BAN";
        company4.ShippingAddress.State = "PLM";
        company5.ShippingAddress.State = "MND";


        company1.ShippingAddress.PostalCode = "1000";
        company2.ShippingAddress.PostalCode = "2000";
        company3.ShippingAddress.PostalCode = "3000";
        company4.ShippingAddress.PostalCode = "4000";
        company5.ShippingAddress.PostalCode = "5000";

        company1.ShippingAddress.Country = "Appleland";
        company2.ShippingAddress.Country = "Orangeland";
        company3.ShippingAddress.Country = "Bananaland";
        company4.ShippingAddress.Country = "Plumland";
        company5.ShippingAddress.Country = "Manderinland";

        var people = new List<Person>();
        var companies = new List<Company>();

        people.Add(person1);
        people.Add(person2);
        people.Add(person3);
        people.Add(person4);
        people.Add(person5);

        companies.Add(company1);
        companies.Add(company2);
        companies.Add(company3);
        companies.Add(company4);
        companies.Add(company5);

        PrintPeople(people);
        PrintCompanies(companies);

    }


    public static void PrintPeople(List<Person> ps)
    {
        Console.WriteLine("PRINTING PEOPLE:\n");
        ps.ForEach(PrintPerson);
        Console.WriteLine();
    }
    public static void PrintCompanies(List<Company> cs)
    {
        Console.WriteLine("PRINTING Companies:\n");
        cs.ForEach(PrintCompany);
        Console.WriteLine();
    }
    public static void PrintPerson(Person p)
    {
        Console.WriteLine($"{p.FirstName} {p.LastName}\n{p.ShippingAddress.AddressString()}\n");
    }
    public static void PrintCompany(Company c)
    {
        Console.WriteLine($"Name = {c.Name}\nStreet Address = {c.ShippingAddress.StreetAddress}\nCity = {c.ShippingAddress.City}\nPostal Code = {c.ShippingAddress.PostalCode}\nCountry = {c.ShippingAddress.Country}\n");
    }
}

public class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string AddressString()
    {
         return StreetAddress + "\n" + City + ", " + State + ", " + PostalCode + "\n" + Country;
    }
}
public class Person
{
    public Person()
    {
        ShippingAddress = new Address();
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Address ShippingAddress { get; set; }

}
public class Company
{
    public Company()
    {
        ShippingAddress = new Address();
    }

    public string Name { get; set; }
    public Address ShippingAddress { get; set; }
}