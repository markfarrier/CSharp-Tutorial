// same as last program (csharp_tutorial_14_11) demonstrating Tell, Don't Ask
// I have rewritten this such that the ConstructCustomerName class is now within the Customer class
// Both because it probably makes more sense that way, and also because the code actually suggests
// doing this. (as explained in the previous program comments, I thought it didn't want me to, but
// I glossed over the line that says "This method could be moved onto the Customer class described here,
// eliminating the need for the first null check and ensuring this logic lives in only one place in the application."


using System;


class Program
{
    static void Main(string[] args)
    {
        var cust1 = new Customer("Mr.", "Rick", "Richard", "Esposito", "Jr.");
        Console.WriteLine(cust1.ConstructCustomerName());
        var cust2 = new Customer("Dr.", "Sally", "", "Sanchez", null);  // testing null & empty
        Console.WriteLine(cust2.ConstructCustomerName());
    }
}

public class Customer
{
    private string _title;
    private string _firstName;
    private string _middleName;
    private string _lastName;
    private string _suffix;

    public Customer(string title, string firstName, string middleName, string lastName, string suffix)
    {
        _title = title;
        _firstName = firstName;
        _middleName = middleName;
        _lastName = lastName;
        _suffix = suffix;
    }
    public string Title { get { return _title; } }
    public string FirstName { get { return _firstName; } }
    public string MiddleName { get { return _middleName; } }
    public string LastName { get { return _lastName; } }
    public string Suffix { get { return _suffix; } }

    public string ConstructCustomerName()
    {
        string name = "";
        if (!String.IsNullOrEmpty(_title))
        {
            name += _title + " ";
        }
        if (!String.IsNullOrEmpty(_firstName))
        {
            name += _firstName + " ";
        }
        if (!String.IsNullOrEmpty(_middleName))
        {
            name += _middleName + " ";
        }
        if (!String.IsNullOrEmpty(_lastName))
        {
            name += _lastName + " ";
        }
        if (!String.IsNullOrEmpty(_suffix))
        {
            name += _suffix;
        }
        return name.Trim();
    }
}


