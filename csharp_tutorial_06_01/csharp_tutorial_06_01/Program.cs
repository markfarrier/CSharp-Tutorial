using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            int x = 15;
            int y = 10;
            Console.WriteLine(x < 10); // should return False, as the expression (x < 10) is a boolean which when x=15 is false, and writeline will print the boolean as a string "False".
            Console.WriteLine(y >= 0); // should return False, as the expression (y >= 0) is a boolean which when y=10 is true, and writeline will print the boolean as a string "True".

            // second test:
            // Console.WriteLine(1 <= x <= 10); // x between 1 and 10 inclusive - DOES NOT COMPILE
            // cannot use multiple expressions.  Need to use conditional logic operators.
        }
    }
}
