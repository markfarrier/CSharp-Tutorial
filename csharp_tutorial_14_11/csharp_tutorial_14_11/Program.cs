// here I have rewritten the code to comply with tell don't ask
// In a normal circumstance I would probably put this construct customer name within the Customer class
// I didn't want to completely get rid of the class for this program however, as I wasn't sure if the
// tutorial wanted me to do this even though it's probably much better code. (although the tutorial doesn't
// actually ask me to rewrite this code and simply offers the incorrect code as an example of violating the
// TDA principle.  Anyway, instead of relocating that entire method, I have instead added "append" methods
// to the Customer class - so that it will follow the same sort of procedure in the unedited version and also
// maintain the original ConstructCustomerName.  This way the code more closely resembles the original code
// but the relocation of the business logic brings it in compliance with Tell Don't Ask.


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
        name = customer.appendTitle(name);
        name = customer.appendFirstName(name);
        name = customer.appendMiddleName(name);
        name = customer.appendLastName(name);
        name = customer.appendSuffix(name);
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

    public string appendTitle(string input)
    {
        if (!String.IsNullOrEmpty(this._title)) // wasn't sure if I should be referring to the field or the property in this instance
        {
            input += this._title + " ";

        }
        return input;
    }
    public string appendFirstName(string input)
    {
        if (!String.IsNullOrEmpty(this._firstName))
        {
            input += this._firstName + " ";

        }
        return input;
    }

    public string appendMiddleName(string input)
    {
        if (!String.IsNullOrEmpty(this._middleName))
        {
            input += this._middleName + " ";

        }
        return input;
    }
    public string appendLastName(string input)
    {
        if (!String.IsNullOrEmpty(this._lastName))
        {
            input += this._lastName + " ";

        }
        return input;
    }
    public string appendSuffix(string input)
    {
        if (!String.IsNullOrEmpty(this._suffix))
        {
            input += this._suffix + " ";

        }
        return input;
    }

}


