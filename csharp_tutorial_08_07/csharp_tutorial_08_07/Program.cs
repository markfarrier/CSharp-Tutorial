// "next steps" task is similar to the nested loops I did earlier
// goes through the same for loop, but in different increments

using System;

class Program
{
    static void Main()
    {
        for (int increment = 1; increment <= 4; increment++)
        {
            for (int i = 0; i <= 24; i += increment)
            {
                Console.Write(i);
                if(i+increment > 24)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(",");
                }    
            }
        }
    }
}

