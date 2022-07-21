// this is another modified version of the same code.  Here we have encapsulated the collections such that
// the Orders list is no longer a public field and is instead now private.  An "Orders" property has been
// created to handle retrieval from this private field.  Since customer.Orders no longer points to the field
// and instead returns a carbon copy of this field with the same contents, whenever orders.RemoveAt is called
// it no longer removes from customer.Orders, as when orders = customer.Orders is assigned, it is no longer being
// assigned a reference to the orders field, but given a copy of what that field contains.  As a result, the 
// problematic behaviour exhibited by previous iterations of this code no longer occurs.

// in order to get this program to work I needed to create a new addToOrders class, as customer.Orders.Add no longer
// works due to the fact that the data being added stops existing outside the scope of the operation.  An orders list
// is retrieved and added to, but isn't actually written to the field, so any subsequent calls to customer.Orders 
// will not contain this information.

using System;
using System.Collections.Generic;

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
            orders = customer.Orders;
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
    public List<Order> Orders
    {
        get
        {
            return new List<Order>(_orders);
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