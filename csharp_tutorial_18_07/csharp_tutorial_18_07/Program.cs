// In this iteration of the program, we are creating an instance of IOrderRepository directly in the method
// This will cause coupling problems.  It violates the Open-Closed Principle.  The only way to change persistence behaviour in future is to modify the code.

// the code from the tutorial instantiates orderRepository as a new EntityFrameworkOrderReposity
// not sure why they changed the variable name.  Perhaps wanted to demonstrate it's a more generic type?
// the tutorial has no information on this however, so I decided to leave it as a DbOrderRepository

// I changed the code from last tutorial to remove the IOrderRepository argument from CompleteOrder, as it's now instantiating in the called method rather than
// outside the method in the main method (thus previously requiring the argument as a parameter)


using System;

class Program
{
	static void Main()
	{
		Store store1 = new Store("Bob's Hardware", "PaySal", "12345");
		Store store2 = new Store("Bob's Hardware", "PaySal", "12345");

		CompleteOrder(store1, "111111111111", "04/26", Convert.ToDecimal(110.59));
		CompleteOrder(store2, "222222222222", "08/23", Convert.ToDecimal(110.59));

	}

	// decided to take some liberties in the arguments CompleteOrder would take in, as I also moved the ProcessCard methods onto this method
	static void CompleteOrder(Store store, string cardNumber, string expiration, decimal amount)
	{
		IOrderRepository orderRepository = new DbOrderRepository();
		store.ProcessCard(cardNumber, expiration, amount);
		orderRepository.Add(new Order());
	}
}

