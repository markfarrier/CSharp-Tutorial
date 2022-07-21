// this program asks for user inputs (either in the form of "+ [item]" or "- [item]" or "--") in order to generate a shopping list

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("CREATE YOUR SHOPPING LIST! (type 'finish' to finish)");
        var shoppingList = new List<string>();
        while(true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            string UserInput = Console.ReadLine();
            if (UserInput.ToLower() == "finish")
            {
                Console.WriteLine("Shopping list is now complete! Items in list are as follows:");
                shoppingList.ForEach(Console.WriteLine);
                break;
            }
            else if (UserInput.StartsWith("+ "))
            {
                string addedItem = UserInput.TrimStart(new char[] { '+', ' ' });
                if (shoppingList.Contains(addedItem))
                {
                    Console.Write("Item has already been added to list.");
                }
                else
                {
                    shoppingList.Insert(0, addedItem);
                    Console.Write($"Shopping list has now been updated.  Item ({addedItem}) has now been added to the list.");

                }
                Console.WriteLine("  Items in list are as follows:");
                shoppingList.ForEach(Console.WriteLine);
            }
            else if (UserInput.StartsWith("- "))
            {
                string removedItem = UserInput.TrimStart(new char[] { '-', ' ' });
                shoppingList.Remove(removedItem);
                Console.WriteLine($"Shopping list has now been updated.  Item ({removedItem}) has now been removed from the list.  Items in list are as follows:");
                shoppingList.ForEach(Console.WriteLine);

            }
            else if (UserInput.StartsWith("--"))
            {
                shoppingList.Clear();
                Console.WriteLine($"Shopping list has now been cleared.  List is now empty.");
            }
            else
            {
                Console.WriteLine("INVALID INPUT!  Must be in the form of \" + [item]\" or \" - [item]\" or \"--\"");
            }
        }
    }
}