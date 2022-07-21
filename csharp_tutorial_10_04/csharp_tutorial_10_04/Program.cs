// this does the same thing as previous project, except it uses a while loop, iterating the index at every pass until it breaks the condition (of the index being higher than the list length).
// Once again, it utilizes the "Count" variable to do this

using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            var myList = new List<int>() { 10, 20, 30 };
            int index = 0;
            while (index < myList.Count)
            {
                Console.WriteLine(myList[index]);
                index++; // loop will be infinite if index is not incremented
            }
        }
    }
}
