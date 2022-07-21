// here's another iteration of this code, this time utilizing the ReadOnlyCollection as a means of imposing
// proper encapsulation.  This required some conversion in the main method when the orders variable is 
// assigned, as it is a generic list and thus incompatible with customer.Orders until it's converted back to
// a generic list.  Likewise with the last program, this successfully prevents the problematic behaviour
// previous iterations of this program exhibited. (removing from both orders and customer.Orders)


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
            while (orders.Count > 0)
            {
                Console.WriteLine(orders[0].OrderNumber);
                orders.RemoveAt(0); // don't write code like this
            }
        }
        Console.WriteLine($"Customer 1 Order Count: {customer1.Orders.Count}");
        Console.WriteLine($"Customer 2 Order Count: {customer2.Orders.Count}");
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
    private ReadOnlyCollection<Order> _ordersView;
    public ReadOnlyCollection<Order> Orders
    {
        get
        {
            if (_ordersView == null)
            {
                _ordersView = new ReadOnlyCollection<Order>(_orders);
            }
            return _ordersView;
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