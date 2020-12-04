using System;

namespace ch04_pro01_table_of_powers
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Squares and Cubes table");
			Console.Write("Enter an integer: ");
			String num = Console.ReadLine();
			Double num1 = Convert.ToDouble(num);
		
			for (int i = 0 +1; i < num1+1; i++)
			{Double num1sq = i * i;
			Double num1cu = i * i* i;
			Console.WriteLine(i +"	"+num1sq+"	"+num1cu);

			}
		}
	}
}
