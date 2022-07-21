
public class CreditCardDetails
{
	private string _cardNumber;
	private string _expiration;
	public CreditCardDetails(string cardNumber, string expiration)
	{
		_cardNumber = cardNumber;
		_expiration = expiration;
	}
	public string CardNumber { get { return _cardNumber; } }
	public string Expiration { get { return _expiration; } }

}
