using System;

namespace ch05_methods
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Call methods");
			// prompt user to enter a whole number
			// convert the unput to a number
			// print number
			int n = GetInt("Enter a whole number: ");
			Console.WriteLine("You entered the number: " + n);

			int age = GetInt("Enter actor age: ");
			Console.WriteLine("Actor's age is: " + age);




			Console.WriteLine("Bye!");
		}

		private static int GetInt(String prompt)
		{
			
			int n = 0;
			Boolean success = false;
			while (!success)
			{
				Console.Write(prompt);
				try
				{
					n = int.Parse(Console.ReadLine());
					success = true;
				}
				catch (Exception e)
				{

					Console.WriteLine("invalid entry. not a whole number. Try again" );
				}
			}
			return n;
		}
	}
}
