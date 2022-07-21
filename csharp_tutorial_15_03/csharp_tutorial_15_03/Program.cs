// code from tutorial demonstrating how access to a namespace can be obtained via class prefix

using System;

namespace GettingStartedTutorials.CSharp.NamespaceLesson
{
    public class Program
    {
        public static void Main()
        {
            var brendan = new GettingStartedTutorials.CSharp.NamespaceLesson.Models.Person { Name = "Brendan" };
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