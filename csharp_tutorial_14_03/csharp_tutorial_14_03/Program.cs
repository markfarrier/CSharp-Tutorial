// again, not technically part of tutorial
// this code demonstrates that when a value type (presumably n1/n2) contains a data member of a reference type (presumably the tags list), the reference is copied onto the new 
// value type instance and shared between them, both having access to the same reference type instance rather than unique versions of the same object.
// So in this case, n2.Number can be modified without it changing n1.Number, as these fields are value types.  However, the tags list is a reference type, so n1.tags and n2.tags
// point to the same piece of memory, so any operations performed on the n2.tags list will also be performed on the n1.tags list.  Even though n1 and n2 are separate instances,
// they share a common reference type.  This program exhibits similar behaviour to the first program in the encapsulation tutorial section that confused me.  Proper encapsulation
// will prevent this behaviour.  As it stands, addtag exposes the tags list to write operations, and since this list is a reference type it will be shared across all instances of
// TaggedInteger.  Thus while changing the Number field in one TaggedInteger isn't going to affect another, calling the addTag method is going to affect both. 

// I said that this code is similar to csharp_tutorial_14_01, however, it differs due the fact that TaggedInteger is a struct and therefore a value type, thus not quite as exposed 
// to the pitfalls of poor encapsulation. (but still exposed as this example demonstrates, due to the fact that while TaggedInteger is a value type, it contains a reference type)
// The encapsulation tutorial problem uses Classes, which are reference types - thus emphasising the need for encapsulation a lot more.

using System;
using System.Collections.Generic;

public struct TaggedInteger
{
    public int Number;
    private List<string> tags;

    public TaggedInteger(int n)
    {
        Number = n;
        tags = new List<string>();
    }

    public void AddTag(string tag) => tags.Add(tag);

    public override string ToString() => $"{Number} [{string.Join(", ", tags)}]";
}

public class Program
{
    public static void Main()
    {
        var n1 = new TaggedInteger(0);
        n1.AddTag("A");
        Console.WriteLine(n1);  // output: 0 [A]

        var n2 = n1;
        n2.Number = 7;
        n2.AddTag("B");

        Console.WriteLine(n1);  // output: 0 [A, B]
        Console.WriteLine(n2);  // output: 7 [A, B]
    }
}