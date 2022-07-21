using System;

public class StwipeAdapter : IPaymentProcessorAdapter
{
    public StwipeAdapter()
	{
	}
    public bool ProcessPayment(string merchantId, string cardNumber, string expiration,
                        decimal amount)
    {
        if (isExpired(expiration))
        {
            return false;
        }
        var provider = new StwipeProvider(merchantId);
        return provider.Pay(cardNumber, expiration, amount);
    }

    public bool isExpired(string expiration)
    {
        DateTime now = DateTime.Now;
        int currentYear = now.Year;
        int currentMonth = now.Month;
        int expirationMonth = Convert.ToInt32(expiration.Substring(0, 2));
        int expirationYear = Convert.ToInt32(expiration.Substring(3, 2)) + 2000;

        if (expirationYear < currentYear)
        {
            return true;
        }
        if (expirationYear == currentYear && expirationMonth < currentMonth)
        {
            return true;
        }
        return false;
    }
}