// second program in the Design Pattern tutorial section
// the next program will implement a Factory implementation pattern
// this is a "before" code, before this is implemented
// essentially, I've just gotten the "Store" class to work with previous program

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

