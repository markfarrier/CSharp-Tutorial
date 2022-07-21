public class OrderCheckoutException : System.Exception
{
    public OrderCheckoutException(System.Exception innerException)
        : base("There was an error while checking out.", innerException)
    {
    }
}