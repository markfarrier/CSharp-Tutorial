using System;

class InvalidPaymentProviderException : Exception
{
	public InvalidPaymentProviderException()
	{
	}
	public InvalidPaymentProviderException(string message) : base (message)
	{
	}
	public InvalidPaymentProviderException(string message, Exception inner) : base (message, inner)
	{
	}
}

