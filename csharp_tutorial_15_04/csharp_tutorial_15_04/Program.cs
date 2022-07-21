// more code from tutorial demonstrating how you can use a namespace by adding it to the current scope via a using statement

// notes: if more than 1 class of the same name is included in same scope, specify all or part of the namespace - e.g. NameSpaceLesson.Models.Person
// can assign a special name to these duplicate classes - e.g. using NamespacePerson = GettingStartedTutorials.CSharp.NamespaceLesson.Models.Person; 

using GettingStartedTutorials.CSharp.NamespaceLesson.Models;

namespace GettingStartedTutorials.CSharp.NamespaceLesson
{
    public class Program
    {
        public static void Main()
        {
            var brendan = new Person { Name = "Brendan" };
            System.Console.WriteLine($"Hello {brendan.Name}!");
        }
    }
}

namespace GettingStartedTutorials.CSharp.NamespaceLesson.Models
{
    public class Person
    {
        public string Name { get; set; }
    }
}