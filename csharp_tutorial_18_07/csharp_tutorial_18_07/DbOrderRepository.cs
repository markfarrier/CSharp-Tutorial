

using System;
using System.Collections.Generic;

public class DbOrderRepository : IOrderRepository
{
    private List<Order> _orders;
    public DbOrderRepository()
	{
        _orders = new List<Order>();
	}
    public List<Order> Orders { get { return _orders; } }
    public void Add(Order order)
	{
        // I decided to add writelines for the commented out functionality (not expected to be implemented) in order to simulate this method's function
        // in the outputted console text.
        Console.WriteLine("Verifying order...");
        Console.WriteLine("Processing card...");
        Console.WriteLine("Creating order object...");
        Console.WriteLine("Connecting to database...");
        Console.WriteLine("Converting order object into database statement(s)...");
        Console.WriteLine("Executing database commands...");
        Console.WriteLine("Sending customer confirmation...");
        
        _orders.Add(order);

        Console.WriteLine("\n");
    }
}