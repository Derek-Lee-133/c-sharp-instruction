using System;
using ch07_product_manager.business;

namespace ch07_product_manager
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the product manager");
			Product p1 = new Product();
			p1.code = ".net";
			p1.description = "Murach's C# and .Net";
			p1.price = 58.99;

			Console.WriteLine("p1=$" +(p1));
			
			Product p2 = new Product("java", "Murach's java programming", 59.50);

			Console.WriteLine(p2);




			Console.WriteLine("Bye");
		}
	}
}
