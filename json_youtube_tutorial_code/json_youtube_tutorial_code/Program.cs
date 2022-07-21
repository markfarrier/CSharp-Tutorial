// code I followed in a youtube tutorial on json/serialization

using System;
using System.Text.Json;
using System.Collections.ObjectModel;
using System.Linq;


class Program
{
	static void Main(string[] args)
	{
		string json = JsonSerializer.Serialize(new Product().GetProducts());
		Console.WriteLine("json object \n");
		Console.WriteLine(json);
		
		Console.WriteLine("d-serialized json object");
		var products = JsonSerializer.Deserialize<ObservableCollection<Product>>(json);
		products.ToList().ForEach(p => Console.WriteLine(p.Name));
	}
}


public class Product
{
	public string Name { get; set; }
	public double Price { get; set; }
	public ObservableCollection<Product> GetProducts()
	{
		return new ObservableCollection<Product>()
		{
			new Product(){Name="Mango", Price=10.99},
			new Product(){Name="Apple", Price=15.99},
			new Product(){Name="Banana", Price=13.99}
		};
	}

}