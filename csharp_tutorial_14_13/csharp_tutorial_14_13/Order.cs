using System;
using System.Collections.Generic;
using System.Text;
//using System.DateTime;

public class Order : IOrder
{
	private string _orderNumber;
	private DateTime _orderDate;

	// dateless constructor no longer used but thought I should still keep it in the code
	public Order(string orderNumber)
	{
		_orderNumber = orderNumber;
		_orderDate = DateTime.Now;
	}
	public Order(string orderNumber, DateTime orderDate)
	{
		_orderNumber = orderNumber;
		_orderDate = orderDate;
	}

	public string OrderNumber { get { return _orderNumber; } }
	
	public DateTime OrderDate
	{
		get
		{
			return _orderDate;
		}
		set
		{
			if (value <= Factory.createDateTime())
			{
				_orderDate = value;
			}

			// can uncomment below to get a better idea of what's going on in the code during the test
			
			/*
			else
			{
				Console.WriteLine($"attempt to update to {value} failed");
			}*/
		}
	}

}
