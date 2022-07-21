using System.Collections.Generic;

public interface ICustomer
{
	string Name { get; }
	List<IOrder> Orders { get; }

	void addToOrders(IOrder item);
}