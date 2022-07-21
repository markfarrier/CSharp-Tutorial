using System;

public class Store
{
    private string _name;
    private string _paymentProvider;
    private string _merchantID;
    public string Name { get { return _name; } }
    public string PaymentProvider { get { return _paymentProvider; } }
    public string MerchantId { get { return _merchantID; } }
    public Store(string name, string paymentProvider, string merchantID)
	{
        _name = name;
        _paymentProvider = paymentProvider;
        _merchantID = merchantID;
	}

    public void ProcessCard(string cardNumber, string expiration, decimal amount)
    {
        IPaymentProcessorAdapterFactory factory = new PaymentProcessorAdapterFactory();
      
        IPaymentProcessorAdapter adapter = factory.Create(_paymentProvider);
        
        // decided to rename this method call to ProcessPayment, like it was in earlier tutorial program
        // decided to move the code printing to console that payment couldn't be processed here.
        // otherwise the program is calling a bool method and doing nothing with the return
        // I could have changed the method to be a void, but I wanted to retain the expiration check
        // and didn't want to take too many liberties in how the code should be modified
        if (!adapter.ProcessPayment(_merchantID, cardNumber, expiration, amount))
        {
            Console.WriteLine("Payment could not be processed");
        }
    }
}