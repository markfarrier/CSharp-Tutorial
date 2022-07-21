// implementing the code throwing exceptions from tutorial (code was only the GetAllCustomersByAge method which was incomplete)
// In a real-world use case, an exception should also be thrown when there is an attempt to add a customer with an illegal age

using System;
using System.Collections.Generic;


public class Program
{

	static void Main(string[] args)
	{
		List<Person> people = new List<Person>();
		people.Add(new Person("Mark", 35));
		people.Add(new Person("John", 20));
		people.Add(new Person("Jack", 160));
		people.Add(new Person("Richard", 20));
		people.Add(new Person("Mary", 20));
		people.Add(new Person("Mike", 10));
		people.Add(new Person("Matt", 100));
		people.Add(new Person("Roger", 8));
		people.Add(new Person("Andrew", 5));
		people.Add(new Person("Bertie", 40));
		people.Add(new Person("Ernie", 180));
		people.Add(new Person("Sally", 180));

		printPersonList(people);

		List<Person> newList = GetAllCustomersByAge(20, people); // change number to less than 18 or more than 150 to trigger exception

		printPersonList(newList);
	}

	// I have modified the class below to accept a person list as an argument
	// the code lifted from tutorial was incomplete in this regard, as well as not returning anything etc
	// it could have been operating on a global variable but the code was too incomplete to make sense of it, so took liberties in the rewrite
	public static List<Person> GetAllCustomersByAge(int age, List<Person> people)
	{
		List<Person> output = new List<Person>();
		if (age < 18 || age > 150)
		{
			throw new ArgumentOutOfRangeException("Age must be between 18 and 150.", nameof(age));
		}
		foreach (var person in people)
		{
			if(person.Age == age)
			{
				output.Add(person);
			}
		}
		return output;
	}

	public static void printPersonList(List<Person> people)
	{
		foreach (var person in people)
		{
			Console.WriteLine($"NAME = {person.Name}, AGE = {person.Age}");
		}
		Console.WriteLine();
	}
}
