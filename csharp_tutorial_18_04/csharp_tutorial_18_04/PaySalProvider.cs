using System;

public class PaySalProvider
{
	public void ProcessPayment(string merchantId, CreditCardDetails cardInfo, decimal amount)
	{
		Console.WriteLine("PROCESSING PAYMENT");
		Console.WriteLine($"merchantID = {merchantId}, cardInfo.CardNumber = {cardInfo.CardNumber}, cardInfo.Expiration = {cardInfo.Expiration}, amount = {amount}");
		Console.WriteLine("PAYMENT PROCESSED\n");
	}
}

