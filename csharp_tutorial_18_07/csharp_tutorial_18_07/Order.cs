// tutorial provided direction at how to populate the Order class
// these changes allow the program to follow the Strategy design pattern


public class Order
{
    private readonly IOrderRepository _orderRepository;
    public Order(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }
    public void CompleteOrder()
    {
        // other logic omitted
        _orderRepository.Add(this);
    }
}