// In this iteration of the program, a Repository has been created to e.g. work with databases as if they were collections
// this encapsulates the db calls such that it allows business-level code to remain "persistence ignorant", decoupling them from any particular persistence implementation


using System;

class Program
{
	static void Main()
	{
		Store store1 = new Store("Bob's Hardware", "PaySal", "12345");
		Store store2 = new Store("Bob's Hardware", "PaySal", "12345");
		IOrderRepository orderRepository = new DbOrderRepository();

		CompleteOrder(store1, "111111111111", "04/26", Convert.ToDecimal(110.59), orderRepository);
		CompleteOrder(store2, "222222222222", "08/23", Convert.ToDecimal(110.59), orderRepository);

	}

	// decided to take some liberties in the arguments CompleteOrder would take in, as I also moved the ProcessCard methods onto this method
	static void CompleteOrder(Store store, string cardNumber, string expiration, decimal amount, IOrderRepository orderRepository)
	{
		store.ProcessCard(cardNumber, expiration, amount);
		orderRepository.Add(new Order());
	}
}

