// here's a completed program using some of the code in the tutorial demonstrating functionality of GetMemberIdByName method
// this program runs without throwing any exceptions
// next iteration I will modify the code so that it throws an exception by asking it to find a member without a matching name

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
        Console.WriteLine($"Emma's ID is {GetMemberIdByName("Emma", memberList)}");
        Console.WriteLine($"Eric's ID is {GetMemberIdByName("Eric", memberList)}");
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

