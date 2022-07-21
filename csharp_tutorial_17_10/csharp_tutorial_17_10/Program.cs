// this code demonstrates how you might handle more than one type of exception the same way

using System;

public class Program
{
    public static void Main()
    {



        try
        {
            // uncomment either to trigger catch block.  First is IndexOutOfRangeException.  Second is DivideByZeroException.  Both will trigger same block.

   //         int[] array = new int[3];
			//array[5] = 4;

			//int i = 1;
			//int j = 0;
			//int k = i / j;


		}
        catch (Exception ex) when (ex is IndexOutOfRangeException || ex is DivideByZeroException)
        {
            Console.WriteLine("Exception caught!");
        }

    }
}
