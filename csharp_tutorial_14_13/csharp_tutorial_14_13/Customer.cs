using System;
using System.Collections.Generic;
using System.Text;

public class Customer : ICustomer
{
	private List<IOrder> _orders = new List<IOrder>();
	private string _name;

	public Customer(string name)
	{
		_name = name;
	}

	public string Name { get { return _name; } }

	public List<IOrder> Orders // historic orders property - requirement 1
	{
		get
		{
			return new List<IOrder>(_orders);
		}
	}
	public void addToOrders(IOrder order) // add order method - requirement 2
	{
		_orders.Add(order);
	}
}
