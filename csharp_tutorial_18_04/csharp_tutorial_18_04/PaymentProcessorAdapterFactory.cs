
public class PaymentProcessorAdapterFactory : IPaymentProcessorAdapterFactory
{
    public PaymentProcessorAdapterFactory()
	{
	}
    public IPaymentProcessorAdapter Create(string providerName)
    {
        if (providerName == "Stwipe")
        {
            return new StwipeAdapter();
        }
        else if (providerName == "PaySal")
        {
            return new PaySalAdapter();
        }
        else
        {
            throw new InvalidPaymentProviderException(providerName);
        }
    }
}