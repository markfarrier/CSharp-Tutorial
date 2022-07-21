// simple program iterating through each item in a list, and printing it out - utilizing the "foreach" statement

using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            var myList = new List<string>() { "one", "two", "three" };
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
