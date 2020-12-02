using System;

namespace ch03_for_loop
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("for loops!");
			// indexed for loo[ that will print "hello" n times
			// n is an int entered by the user

			Console.WriteLine("Enter a whole number: ");
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("Hello! " + i);
				{

				}


			}
		}
	}
}

