// this is a modified version of csharp_tutorial_14_01, exhibiting slightly better encapsulation
// In this case, the set methods have been removed from the Customer and Order classes
// This does not prevent the problematic behaviour that occured in the first piece of code,
// as while the order list in Customer no longer has a "set" method, it can still be written to
// (or in this case, removed from) via the orders.RemoveAt method.

// some changes had to be made to the main method in order to accommodate the changes in the
// class, due to the fact that as a result of removing the set method on the name, the Customer
// class now requires a name parameter to instantiate.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var customer1 = new Customer("Steve");
        customer1.Orders.Add(new Order("123"));
        customer1.Orders.Add(new Order("234"));
        customer1.Orders.Add(new Order("345"));

        var customer2 = new Customer("Eric");
        customer2.Orders.Add(new Order("100"));
        customer2.Orders.Add(new Order("200"));
        customer2.Orders.Add(new Order("300"));

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
    public List<Order> Orders { get; } = new List<Order>();
}

public class Order
{
    public Order(string orderNumber)
    {
        OrderNumber = orderNumber;
    }
    public string OrderNumber { get; }
}