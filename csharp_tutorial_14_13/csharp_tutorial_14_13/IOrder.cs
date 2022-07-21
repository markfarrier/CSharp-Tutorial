using System;

public interface IOrder
{
	DateTime OrderDate { get; set; }
	string OrderNumber { get; }
}