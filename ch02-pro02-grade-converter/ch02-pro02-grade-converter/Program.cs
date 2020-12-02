using System;

namespace ch02_pro02_grade_converter
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Letter Grade Converter");
			// create while loop
			String choice = "y";
			while (choice.Equals("y"))
			{
				Console.Write("Enter numerical grade: ");
				String g = Console.ReadLine();
				double g1 = Convert.ToDouble(g);
				{

					if (g1 >= 88)
					{
						Console.WriteLine("A");

					}
					else if (g1 >= 80)
					{
						Console.WriteLine("B");


					}
					else if (g1 >= 67)
					{
						Console.WriteLine("C");
					}
					else if (g1 >= 60)
					{
						Console.WriteLine("D");
					}
					else
					{
						Console.WriteLine("F");
					}
					Console.WriteLine("Continue? (y/n): ");
					choice= Console.ReadLine();

				}
				Console.WriteLine("Bye");
				


			}
			
		}
		
	}
}
