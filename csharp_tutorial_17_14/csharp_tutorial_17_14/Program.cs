// new iteration of the program, wherein I am wrapping a low level exception with a newly created one (OrderCheckoutException)

// program has nothing to do with orders, so it's unlikely the tutorial wanted me to add this to the program I had been working on (with members, getMemberID etc)
// so I'm just going to try and add fudge it into this app, even though it doesn't really make sense contextually
// I would implement a program that would make sense contextually to add this in, but the tutorial provides next to no information about what that program should be
// I have removed the call to a Logger class, which doesn't exist in the program nor is any code provided

// i got the code to run but it doesn't make any sense nor does it do anything useful.  It kindof breaks the test I had set up
// as it is throwing an exception on the try and thus printing out both successful and unsuccessful results for the getMemberId test

using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        List<Member> memberList = new List<Member>();
        RunTest(memberList);
    }
    // modified code below to pass in members list.  Also removed underscore from memberlist indicating private field
    // wasn't sure how program wanted me to structure the code such that it used a private field member list
    // so decided not to, and pass things in as arguments, as I feel like this might take less liberties with the code
    public static int GetMemberIdByName(string memberName, List<Member> memberList)
    {
        Member member = memberList.SingleOrDefault(m => m.Name == memberName);
        if (member != null)
        {
            return member.Id;
        }
        throw new MemberNameNotFoundException(memberName);
    }

    public static void RunTest(List<Member> memberList)
    {
        PopulateListWithTestData(memberList);
        PrintMemberList(memberList);
        TestGetIdMethod(memberList);
    }

    public static void TestGetIdMethod(List<Member> memberList)
    {
        Console.WriteLine("#################################");
        Console.WriteLine("TESTING GETMEMBERIDBYNAME METHOD:");
        Console.WriteLine("#################################");

        //Emma
        Console.WriteLine("Testing Emma:");

        try
        {
            int memberId = GetMemberIdByName("Emma", memberList);
            Console.WriteLine($"Come on in member, {memberId}");
            throw new Exception("This is the inner exception");
        }
        catch (System.Exception ex)
        {
            Console.WriteLine($"You're not on the list.");
            throw new OrderCheckoutException(ex);
        }

        //Brian
        Console.WriteLine("Testing Brian:");

        try
        {
            int memberId = GetMemberIdByName("Brian", memberList);
            Console.WriteLine($"Come on in member, {memberId}");
            throw new Exception("This is the inner exception");

        }
        catch (System.Exception ex)
        {
            Console.WriteLine($"You're not on the list.");
            throw new OrderCheckoutException(ex);
        }
        //    Console.WriteLine($"Emma's ID is {GetMemberIdByName("Emma", memberList)}");
        //    Console.WriteLine($"Brian's ID is {GetMemberIdByName("Brian", memberList)}");
    }



    public static void PopulateListWithTestData(List<Member> memberList)
    {
        memberList.Add(new Member("Mark", 43));
        memberList.Add(new Member("Andrew", 235));
        memberList.Add(new Member("John", 6736));
        memberList.Add(new Member("Emma", 4));
        memberList.Add(new Member("Amy", 32525));
        memberList.Add(new Member("Madison", 55));
        memberList.Add(new Member("Richard", 100));
        memberList.Add(new Member("Matthew", 12));
        memberList.Add(new Member("Eric", 1233));
        memberList.Add(new Member("David", 11));

    }

    public static void PrintMemberList(List<Member> memberList)
    {
        Console.WriteLine("#####################");
        Console.WriteLine("PRINTING MEMBER LIST:");
        Console.WriteLine("#####################");
        foreach (var member in memberList)
        {
            Console.WriteLine($"NAME = {member.Name}, ID = {member.Id}");
        }
        Console.WriteLine();
    }

}

