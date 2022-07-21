using System;
using System.Collections.Generic;
using System.Text;

public static class Factory
{
	public static ICustomer createCustomer(string name)
	{
		return new Customer(name);
	}

	public static IOrder createOrder(string orderNumber)
	{
		return new Order(orderNumber);
	}
	public static IOrder createOrder(string orderNumber, DateTime orderDate)
	{
		return new Order(orderNumber, orderDate);
	}
	public static List<ICustomer> createCustomerList()
	{
		return new List<ICustomer>();
	}
	public static List<IOrder> createOrderList()
	{
		return new List<IOrder>();
	}
	public static DateTime createDateTime()
	{
		return DateTime.Now;
	}
	public static DateTime createDateTime(string time)
	{
		return DateTime.Parse(time);
	}
}

