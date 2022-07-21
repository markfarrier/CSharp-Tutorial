// this code taken from the tutorial demonstrates access modifiers - public, private, and protected
// these modifiers limit what can be accessed and from where
// public allows access by any other piece of code outside the class
// private only allows access from code within the same class
// protected only allows access from code within the same class OR child class
// the internal modifier restricts access only to code within the same assembly
// protected and internal can be used together.  It's a union of allowances rather than of restrictions.
// So a protected internal can be accessed within the assembly OR through a child class.

// in this case, the protected strings FirstName and LastName are defined within the Person class
// but they are accessed from the Student class (in the RosterName method)
// this is allowed because Student is a child class of Person
// if it were attempted to be accessed from a class outside of Person, this code would not work
// this is demonstrated by the commented out code, which when uncommented causes the program to be uncompilable

// likewise with the private set methods, if you for example added "this.FirstName = "Tom";" to the rostername get method
// the program won't compile as despite the fact that Student is a child class of Person, because the method is private
// it can only be accessed within Person

using System;

public class Program
{
    public static void Main()
    {
        var jimmy = new Student("Jimmy", "Jones", new DateTime(1990, 3, 15));
        Console.WriteLine(jimmy.RosterName);
 //       Console.WriteLine(jimmy.FirstName);
    }
}

public class Person
{
    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.DateOfBirth = dateOfBirth;
    }

    protected string FirstName { get; private set; }
    protected string LastName { get; private set; }
    public DateTime DateOfBirth { get; private set; }

    public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }

    public bool IsAnAdult()
    {
        var eighteenYearsAgo = DateTime.Today.AddYears(-18);
        return this.DateOfBirth < eighteenYearsAgo;
    }
}

public class Student : Person
{
    public Student(string firstName, string lastName, DateTime dateOfBirth)
        : base(firstName, lastName, dateOfBirth)
    { }
    public string SchoolName { get; set; }

    public string RosterName { get { return $"{this.LastName}, {this.FirstName}"; } }
}