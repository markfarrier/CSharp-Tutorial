// here's another approach to encapsulation via having the Orders property be an IEnumerable.
// the downside of this is that the private field can still be modified if the property is cast back
// to a list type.  In this case, while I have performed a conversion when setting the contents of
// orders, I have instanciated a new list - therefore the program runs without any problematic behaviour.
// However, if I was to do away with the new keyword and do a straight conversion without creating a new
// instance, this program would share the same problematic behaviour of previous instances and remove
// items from customer.Orders when RemoveAt is performed on order.

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var customer1 = new Customer("Steve");
        customer1.addToOrders(new Order("123"));
        customer1.addToOrders(new Order("234"));
        customer1.addToOrders(new Order("345"));

        var customer2 = new Customer("Eric");
        customer2.addToOrders(new Order("100"));
        customer2.addToOrders(new Order("200"));
        customer2.addToOrders(new Order("300"));

        var customers = new List<Customer>() { customer1, customer2 };

        // print customers
        var orders = new List<Order>();
        foreach (var customer in customers)
        {
            Console.WriteLine(customer.Name);
            Console.WriteLine("Orders:");
            orders = new List<Order>(customer.Orders);
         //   orders = (List<Order>)(customer.Orders);
            while (orders.Count > 0)
            {
                Console.WriteLine(orders[0].OrderNumber);
                orders.RemoveAt(0); // don't write code like this
            }
        }
        Console.WriteLine($"Customer 1 Order Count: {(new List<Order>(customer1.Orders)).Count}");
        Console.WriteLine($"Customer 2 Order Count: {(new List<Order>(customer2.Orders)).Count}");
    }
}

public class Customer
{
    public Customer(string name)
    {
        Name = name;
    }
    public string Name { get; }

    private List<Order> _orders = new List<Order>();
    public IEnumerable<Order> Orders
    {
        get
        {
            return _orders.AsEnumerable(); // in System.Linq namespace
        }
    }
    public void addToOrders(Order item)
    {
        _orders.Add(item);
    }
}

public class Order
{
    public Order(string orderNumber)
    {
        OrderNumber = orderNumber;
    }
    public string OrderNumber { get; }
}