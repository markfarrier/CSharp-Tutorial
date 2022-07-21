using System;

class StwipeProvider
{
	string _merchantID;
	public StwipeProvider(string merchantID)
	{
		_merchantID = merchantID;
	}
	public bool Pay(string cardNumber, string expiration, decimal amount)
	{
		Console.WriteLine("PROCESSING PAYMENT");
		Console.WriteLine($"cardNumber = {cardNumber}, expiration = {expiration}, amount = {amount}");
		Console.WriteLine("PAYMENT PROCESSED\n");

		// wasn't sure why this particular method was a boolean whilst PaySalProvider's ProcessPayment method was a void
		// the adapter classes ProcessPayment method is already boolean, which is where I assume the expiry check should be done
		// makes less sense to do it here when it's not in the other provider class
		// makes a lot more sense to do it in the provider method's common bool method

		// therefore, i'm just returning true here.  I didn't want to infer what the bool meant, or impose a redundant condition. (a second expiry check)
		// it makes the fact that this method is a bool return type redundant.  However, 

		return true; 
	}
}
