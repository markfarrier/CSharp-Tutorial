// this program written in csharp_tutorial_09_10 asks for user inputs (either in the form of "+ [item]" or "- [item]" or "--") in order to generate a shopping list
// I have modified it in this program to have method calls.  I first tried to make shoppingList a global variable, as to not require inputting it into the method
// for some reason this produced errors.  Perhaps I don't know enough yet about how C# handles global variables.

// this code might be more flexible if I did the trim within the if statements rather than the method, and had the method accept the item itself as a parameter
// rather than the entire user input.  However, since this program doesn't need to be extended in any way, I put the trim within the method.

using System;
using System.Collections.Generic;

class Program
{

    static void Main()
    {
        var shoppingList = new List<string>();

        Console.WriteLine("CREATE YOUR SHOPPING LIST! (type 'finish' to finish)");
        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "finish")
            {
                finish(shoppingList);
                break; // break cannot go within the method
            }
            else if (userInput.StartsWith("+ ")) addItem(shoppingList, userInput);
            else if (userInput.StartsWith("- ")) removeItem(shoppingList, userInput);
            else if (userInput.StartsWith("--")) clearList(shoppingList);
            else invalidInput();
        }
    }
    static void addItem(List<string> list, string input)
    {
        string addedItem = input.TrimStart(new char[] { '+', ' ' });
        if (list.Contains(addedItem))
        {
            Console.Write("Item has already been added to list.");
        }
        else
        {
            list.Insert(0, addedItem);
            Console.Write($"Shopping list has now been updated.  Item ({addedItem}) has now been added to the list.");

        }
        Console.WriteLine("  Items in list are as follows:");
        list.ForEach(Console.WriteLine);
    }
    static void removeItem(List<string> list, string input)
    {
        string removedItem = input.TrimStart(new char[] { '-', ' ' });
        list.Remove(removedItem);
        Console.WriteLine($"Shopping list has now been updated.  Item ({removedItem}) has now been removed from the list.  Items in list are as follows:");
        list.ForEach(Console.WriteLine);

    }
    static void clearList(List<string> list)
    {
        list.Clear();
        Console.WriteLine($"Shopping list has now been cleared.  List is now empty.");
    }
    static void invalidInput()
    {
        Console.WriteLine("INVALID INPUT!  Must be in the form of \" + [item]\" or \" - [item]\" or \"--\"");
    }
    static void finish(List<string> list)
    {
        Console.WriteLine("Shopping list is now complete! Items in list are as follows:");
        list.ForEach(Console.WriteLine);
    }

}