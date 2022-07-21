using System;
using System.Collections.Generic;


class Program
{
	// only one line of code in main method simply calling another method, so it's probably redundant.  Leaving it as is however as it allows the program to be extended.
	static void Main()
	{
		testSuite(); 
	}

	static void runTest(List<string> tokens)
	{
		Console.WriteLine("########");
		Console.WriteLine("NEW TEST");
		Console.WriteLine("########\n");


		foreach (string token in tokens)
		{
			testToken(token);
		}

		Console.WriteLine();
	}

	static void testSuite()
	{
		runTest(new List<string> { "12345", "1234", "123456" });
		runTest(new List<string> { "12345", "1234567890", "123456" });
		runTest(new List<string> { "12345", "", "123456" });
		runTest(new List<string> { "12345", null, "123456" });

	}

	static void testToken(string token)
	{
		Console.WriteLine($"TESTING TOKEN {token}");
		Console.WriteLine("---------------------------------");
		Console.WriteLine("RESULTS:");
		foreach (var item in GetAccessPermissions(token))
		{
			Console.WriteLine(item);
		}
		Console.WriteLine();

	}

	public static List<string> GetAccessPermissions(string token)
	{
		if (token == null || token == "")
		{
			throw new MyMissingTokenException();
		}
		if (token.Length > 9)
		{
			throw new MyInvalidTokenException(token);
		}
		return new List<string> { "ReadLessons", "ReviewLessons" };
	}
}

