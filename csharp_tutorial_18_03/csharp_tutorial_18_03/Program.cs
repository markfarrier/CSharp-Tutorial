
// this is a modification of the previous program that added the Store class
// I have replaced some code in the Store class to implement a Factory method

using System;

class Program
{
	static void Main()
	{
		Store store1 = new Store("Bob's Hardware", "PaySal", "12345");
		Store store2 = new Store("Bob's Hardware", "PaySal", "12345");

		store1.ProcessCard("111111111111", "04/26", Convert.ToDecimal(110.59));
		store2.ProcessCard("222222222222", "08/23", Convert.ToDecimal(110.59));

	}
}

