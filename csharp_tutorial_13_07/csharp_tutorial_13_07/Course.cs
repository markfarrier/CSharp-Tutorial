using System;
using System.Collections.Generic;
using System.Text;

public class Course
{
    public Course(string name)
    {
        this.Students = new List<Student>();
        this.CourseName = name;
    }
    private List<Student> Students { get; set; }
    private string CourseName { get; set; } // inaccessable outside Course class
    public string getCourseName() // accessable outside Course class
    {
        return this.CourseName;
    }
    public List<string> getRoster()
    {
        List<string> result = new List<string>();
        foreach (var student in this.Students)
		{
            result.Add(student.RosterName);
		}
        return result;
    }

    public void addToRoster(Student student)
    {
        Students.Add(student);
    }
}
