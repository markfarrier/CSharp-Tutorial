// This is the project at the end of the tutorial.  I have started off with the csharp_tutorial_14_05 code.
// The requirements of this project are:


//  Customers have a property exposing their historic Orders
//  Customers expose a method for adding an Order
//  Trying to add a null Order should do nothing
//  Trying to add an Order with an existing OrderNumber should replace the existing Order (not add a duplicate)
//  Orders should expose an OrderDate (which can be read/write)
//  Trying to add an order with an OrderDate in the future should do nothing

// I wasn't sure if it required the "duplicate order number" functionality to only apply to individual customers
// (i.e. such that the different customers can have identical order numbers), or if it applied to all customers.
// I think the former may have only been required, but I decided to do the latter instead as a real world application
// of this would probably require no duplicates across the board.
// I didn't necessarily have to have a master order list, and that might be extraneous information
// However, the alternative solution would have required looping through customers each time to check for duplicates
// Perhaps better to have a separate list, although maybe not, as it's storing the same information twice.
// It's more expedient for the programmer to have this master list I think, but that's not the reason I did it that way,  
// and instead was more worried about extraneous operations than extraneous memory storage.

// I tried to write this code across separate files, and also use interfaces, to get some practice employing better
// programming techniques.

// not sure if I should be passing the customers/masterOrderList in as arguments so often, rather than use global variables
// global variables didn't seem like the right solution but it feels like i may have overlooked an alternative.  Maybe not.




using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<ICustomer> customers = Factory.createCustomerList();
        List<IOrder> masterOrderList = Factory.createOrderList();

        runTestSuite(customers, masterOrderList);
    }

    public static void runTestSuite(List<ICustomer> customers, List<IOrder> masterOrderList)
	{
        addTestCustomers(customers);
        addTestOrders(customers, masterOrderList);
        printOrderTest(customers);
        printDateTest(customers);
    }

    public static void addTestCustomers(List<ICustomer> customers)
	{
        customers.Add(Factory.createCustomer("Steve"));
        customers.Add(Factory.createCustomer("Eric"));
        customers.Add(Factory.createCustomer("Jared"));
        customers.Add(Factory.createCustomer("Bevin"));
        customers.Add(Factory.createCustomer("Chloe"));
        customers.Add(Factory.createCustomer("Marge"));
        customers.Add(Factory.createCustomer("Darren"));
        customers.Add(Factory.createCustomer("Donovan"));
        customers.Add(Factory.createCustomer("Debra"));
        customers.Add(Factory.createCustomer("Scott"));
    }

    public static void addTestOrders(List<ICustomer> customers, List<IOrder> masterOrderList)
	{
        newOrder(customers[0], "123", masterOrderList);
        newOrder(customers[0], "123", masterOrderList); // shouldn't add duplicate order#123
        newOrder(customers[0], "123", masterOrderList); // shouldn't add duplicate order#123

        newOrder(customers[1], "100", masterOrderList);
        newOrder(customers[1], "200", masterOrderList);
        newOrder(customers[1], "300", masterOrderList);

        newOrder(customers[2], "340", masterOrderList);
        newOrder(customers[2], null, masterOrderList); // shouldn't add null order
        newOrder(customers[2], "580", masterOrderList);

        newOrder(customers[3], null, masterOrderList); // shouldn't add null order
        newOrder(customers[3], "780", masterOrderList);

        newOrder(customers[4], "800", masterOrderList);
        newOrder(customers[4], "220", masterOrderList);
        newOrder(customers[4], null, masterOrderList); // shouldn't add null order

        newOrder(customers[5], "720", masterOrderList);
        newOrder(customers[5], "200", masterOrderList); // shouldn't add duplicate order#200
        newOrder(customers[5], "333", masterOrderList);

        newOrder(customers[6], "888", masterOrderList);
        newOrder(customers[6], "999", masterOrderList, Factory.createDateTime("21/04/2012 08:34:22"));
        newOrder(customers[6], "111", masterOrderList);

        newOrder(customers[7], "555", masterOrderList);
        newOrder(customers[7], "666", masterOrderList, Factory.createDateTime("24/01/2050 03:33:33")); // shouldn't add unless it's post 2050
        newOrder(customers[7], "777", masterOrderList);

        newOrder(customers[8], "222", masterOrderList);
        newOrder(customers[8], "333", masterOrderList, Factory.createDateTime("22/08/2016 18:30:01")); // shouldn't add duplicate order#333, even though it's a different time
        newOrder(customers[8], "444", masterOrderList);

        newOrder(customers[9], "319", masterOrderList);
        newOrder(customers[9], "320", masterOrderList, Factory.createDateTime("16/09/2014 19:40:02"));
        newOrder(customers[9], "321", masterOrderList);

    }

    public static void printOrderTest(List<ICustomer> customers) // also tests encapsulation as per first program in tutorial section
	{
        // modified code from original program in tutorial section.  Now includes different formatting, order date, and count in the foreach loop
        var orders = new List<IOrder>();
        foreach (var customer in customers)
        {
            Console.WriteLine(customer.Name);
            Console.WriteLine("ORDERS:");
            orders = customer.Orders;
            while (orders.Count > 0)
            {
                Console.WriteLine($"Number = {orders[0].OrderNumber}, Date = {orders[0].OrderDate}");
                orders.RemoveAt(0); // don't write code like this
            }
            Console.WriteLine($"Count: {customer.Orders.Count}\n\n");
        }
    }

    public static void printDateTest(List<ICustomer> customers) // also tests encapsulation as per first program in tutorial section
    {
        // one final test to check that setting the order date is working correctly
        Console.WriteLine("\n\nSET ORDER DATE TEST:\n");

        Console.WriteLine($"Original Order Date = {customers[9].Orders[1].OrderDate}");

        customers[9].Orders[1].OrderDate = Factory.createDateTime("16/09/2014 19:40:03");
        Console.WriteLine($"New Order Date = {customers[9].Orders[1].OrderDate}");

        customers[9].Orders[1].OrderDate = Factory.createDateTime("16/09/2050 19:40:03");
        Console.WriteLine($"New Order Date = {customers[9].Orders[1].OrderDate}\n"); // should be no change


        // testing same operation on an order with default OrderDate
        Console.WriteLine($"Original Order Date = {customers[9].Orders[0].OrderDate}");

        customers[9].Orders[0].OrderDate = Factory.createDateTime("14/04/2014 20:50:03");
        Console.WriteLine($"New Order Date = {customers[9].Orders[0].OrderDate}");

        customers[9].Orders[0].OrderDate = Factory.createDateTime("14/04/2050 20:50:03");
        Console.WriteLine($"New Order Date = {customers[9].Orders[0].OrderDate}\n"); // should be no change


        // testing same operation except I'm updating to an illegal order date on first operation rather than second
        Console.WriteLine($"Original Order Date = {customers[9].Orders[2].OrderDate}");

        customers[9].Orders[2].OrderDate = Factory.createDateTime("13/03/2050 03:03:03");
        Console.WriteLine($"New Order Date = {customers[9].Orders[2].OrderDate}");

        customers[9].Orders[2].OrderDate = Factory.createDateTime("13/03/2010 03:03:03");
        Console.WriteLine($"New Order Date = {customers[9].Orders[2].OrderDate}\n"); // should be no change
    }


    // using method overloading to create a default parameter
    public static void newOrder(ICustomer customer, string orderNumber, List<IOrder> masterOrderList)
    {
        newOrder(customer, orderNumber, masterOrderList, Factory.createDateTime());
    }

    public static void newOrder(ICustomer customer, string orderNumber, List<IOrder> masterOrderList, DateTime orderDate)
    {
        IOrder addedOrder = Factory.createOrder(orderNumber, orderDate);
        // I could have used masterOrderList.Contains, but the addition of order dates meant orders with a common number
        // but a unique date would slip through the cracks
        // unsure if there's a list contains method that searches elements of an item in a list, rather than checking the 
        // whole item itself.  Couldn't find one in a cursory search, so i created a method "containsOrder"
        if (!containsOrder(orderNumber, masterOrderList) && (orderNumber != null) && (orderDate < Factory.createDateTime()))
        {
            masterOrderList.Add(addedOrder);
            customer.addToOrders(addedOrder);
        }
    }


    // no longer needed, was for debugging
    /*
    public static void printOrderList(List<IOrder> orders)
	{
        foreach (IOrder order in orders)
        {
            Console.WriteLine($"ORDER NUMBER = {order.OrderNumber}.  ORDER TIME = {order.OrderDate}");
        }

    }*/

    public static bool containsOrder(string order, List<IOrder> orders)
	{
        foreach (var o in orders)
		{
            if(o.OrderNumber == order)
			{
                return true;
			}
		}
        return false;
	}

    /*
    public static List<ICustomer> updateCustomerList(List<ICustomer> customers, ICustomer customer)
    {
        customers.Add(customer);
        return customers;
    }


    public static void newCustomer(List<ICustomer> customers, string name)
	{
        customers = updateCustomerList(customers, Factory.createCustomer("Steve"));
    }*/
}



