// this is a modification of the previous program that implemented a factory method
// In this iteration of the program, I have replaced the factory method with a factory class+interface

// right now, the processCard method has to instantiate the factory class.  Program will resolve this issue via a Strategy design pattern.

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

