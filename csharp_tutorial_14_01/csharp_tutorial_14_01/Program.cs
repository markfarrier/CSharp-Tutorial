// this code taken from the tutorial is an example of poor encapsulation

// this actually confused me quite a lot as I could understand why the code was poorly encapsulated
// and reading through the tutorial I could understand the methods to properly encapsulate a program
// and protect things from being written to unexpectedly - however I could not understand how the main
// method of this program was writing.  I thought orders = customer.Orders was simply assinging the contents
// of customer.Orders to the new variable orders, and that these two things were distinct.  I did not understand
// these two things shared a common reference to the same piece of memory.

// this lead me to reading up on the difference between value types and reference types, which weren't covered
// previously in this tutorial.

// anyway, because lists are reference types, and classes are reference types (although could be a struct and exhibit similar behaviour,
// since references types shared between different instances of value types aren't unique), that means that every time orders.RemoveAt
// is called, it also removes from customer.Orders, since orders = customer.Orders.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var customer1 = new Customer() { Name = "Steve" };
        customer1.Orders.Add(new Order("123"));
        customer1.Orders.Add(new Order("234"));
        customer1.Orders.Add(new Order("345"));

        var customer2 = new Customer() { Name = "Eric" };
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
                //Console.WriteLine(orders[0].OrderNumber);
                Console.WriteLine($"ORDERS VARIABLE = {orders.Count}, CUSTOMER ORDERS = {customer.Orders.Count}");
                orders.RemoveAt(0); // don't write code like this
            }
        }
        Console.WriteLine($"Customer 1 Order Count: {customer1.Orders.Count}");
        Console.WriteLine($"Customer 2 Order Count: {customer2.Orders.Count}");
    }
}

public class Customer
{
    public string Name { get; set; }
    public List<Order> Orders { get; set; } = new List<Order>();
}

public class Order
{
    public Order(string orderNumber)
    {
        OrderNumber = orderNumber;
    }
    public string OrderNumber { get; set; }
}