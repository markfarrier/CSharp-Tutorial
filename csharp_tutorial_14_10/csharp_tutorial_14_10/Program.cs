// this code below is an example of violating the "Tell, Don't Ask" principle
// this principle states that instead of querying an object's state then performing an action with the object
// it is usually better to put that logical decisionmaking within the class itself and let it decide what to do
// rather than make decisions from outside the class

// more succinctly put "colocate data and methods that operate on that data"

// the code below is violating tell don't ask because of all of the IsNullOrEmpty calls
// an alternative method that wouldn't violate this principle would involve relocating all of this logic into the
// Customer class itself.


using System;


class Program
{
	static void Main(string[] args)
	{
        var cust1 = new Customer("Mr.", "Rick", "Richard", "Esposito", "Jr.");
        Console.WriteLine(ConstructCustomerName(cust1));
        var cust2 = new Customer("Dr.", "Sally", "", "Sanchez", null);  // testing null & empty
        Console.WriteLine(ConstructCustomerName(cust2));


    }
    public static string ConstructCustomerName(Customer customer)
    {
        if (customer == null) return "";
        string name = "";
        if (!String.IsNullOrEmpty(customer.Title))
        {
            name += customer.Title + " ";
        }
        if (!String.IsNullOrEmpty(customer.FirstName))
        {
            name += customer.FirstName + " ";
        }
        if (!String.IsNullOrEmpty(customer.MiddleName))
        {
            name += customer.MiddleName + " ";
        }
        if (!String.IsNullOrEmpty(customer.LastName))
        {
            name += customer.LastName + " ";
        }
        if (!String.IsNullOrEmpty(customer.Suffix))
        {
            name += customer.Suffix;
        }
        return name.Trim();
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

}


