// final program from this tutorial section on scope/accessibility

 /*
    Expand upon the Person and Student example seen above by creating a Course class with a List<Student> to keep track of whom is enrolled
    Make sure code using Course can't get access to the Student objects directly.

    Create two methods on the Course class one which provides its name and another which provides a list of the RosterNames of the enrolled students.
    Use these methods to print out the information for the course rather than accessing the collection of enrolled student objects directly.
    While writing this, try accessing some of the code restricted by the access modifiers and notice the error messages you receive when trying.
 */

// I'm a little confused by the wording here.  I assume it wants me to have a list of student objects within the course class, but the list of roster names it
// wants me to write a method to return is simply a string list.


// come back to this

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Course> courses = new List<Course>();
        runTestSuite(courses);
    }

    public static void runTestSuite(List<Course> courses)
	{
        createAndPopulateCourses(courses);
        printAllRosters(courses);
    }

    public static void printAllRosters(List<Course> courses)
	{
        foreach (Course course in courses)
		{
            Console.WriteLine($"{course.getCourseName().ToUpper()}:");
            printRoster(course);
            Console.WriteLine();

        }
    }

    public static void printRoster(Course course)
	{
        foreach (var rosterName in course.getRoster())
        {
            Console.WriteLine(rosterName);
        }
    }

    public static void createAndPopulateCourses(List<Course> courses)
	{
        var course1 = new Course("Math");
        course1.addToRoster(new Student("Jimmy", "Jones", new DateTime(1990, 3, 15)));
        course1.addToRoster(new Student("James", "Jameson", new DateTime(1995, 5, 20)));
        course1.addToRoster(new Student("Jared", "Jackson", new DateTime(1990, 9, 25)));
        courses.Add(course1);

        var course2 = new Course("Science");
        course2.addToRoster(new Student("Mark", "Madison", new DateTime(1988, 1, 15)));
        course2.addToRoster(new Student("Mary", "Maryson", new DateTime(1994, 6, 20)));
        course2.addToRoster(new Student("Indigo", "Jones", new DateTime(1998, 3, 25)));
        courses.Add(course2);

        var course3 = new Course("English");
        course3.addToRoster(new Student("Trish", "Black", new DateTime(1993, 2, 15)));
        course3.addToRoster(new Student("Walt", "White", new DateTime(1999, 7, 20)));
        course3.addToRoster(new Student("Jimmy", "James", new DateTime(2000, 8, 25)));
        courses.Add(course3);

        var course4 = new Course("Spanish");
        course4.addToRoster(new Student("John", "Johnson", new DateTime(1994, 4, 15)));
        course4.addToRoster(new Student("Sylvia", "Storm", new DateTime(1996, 9, 25)));
        courses.Add(course4);

        var course5 = new Course("Biology");
        course5.addToRoster(new Student("Tim", "Thompson", new DateTime(1997, 11, 15)));
        course5.addToRoster(new Student("Richard", "Angel", new DateTime(1998, 11, 20)));
        course5.addToRoster(new Student("Bob", "Ramirez", new DateTime(2004, 5, 25)));
        course5.addToRoster(new Student("Paul", "Parker", new DateTime(2004, 5, 25)));
        courses.Add(course5);

    }
}


