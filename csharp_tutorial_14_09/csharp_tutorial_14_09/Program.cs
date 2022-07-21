// code demonstrating interfaces
// not exactly sure what the tutorial is wanting me to actually do with the code, except to teach the proper syntax for
// creating interfaces.  I haven't done anything with it aside from get it into a state where it will at least compile
//
// interfaces are implemented by other classes, as opposed to abstract classes which inherit them
// interfaces impose a contract onto any class that inherits them by forcing it to contain the same members.
// abstract classes can operate in the same manner if all methods are defined to be abstract, but this
// would be redundant, and you may as well just use interfaces at that point.
//
// C# doesn't allow inheritence from multiple classes, but it does allow implementation from multiple interfaces

// interfaces cannot be instantiated, as the commented code within the Foo method demonstrates.

// interfaces impose encapsulation by imposing an explicit set of rules that define how a programs components will react

using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello World!");
	}
	IProductRepository repository; // field definition

	// use for return or parameter type
	public IProductRepository Foo(IProductRepository repo)
	{
		IProductRepository anotherRepo = repo; // use as local

		//	var doNotDoThis = new IProductRepository(); // compilation error - interfaces cannot be instantiated

		return anotherRepo;
	}
}

public interface IProductRepository
{
	List<Product> List();

}

public interface BaseRepository
{
	List<Product> List();
}

public class Product
{

}


public class InMemoryProductRepository : BaseRepository, IProductRepository
{
	private List<Product> _list;
	public List<Product> List() {
		return _list;
	}
}