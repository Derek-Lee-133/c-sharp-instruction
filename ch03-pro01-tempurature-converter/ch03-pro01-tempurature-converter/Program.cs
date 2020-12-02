using System;

namespace ch03_pro01_tempurature_converter
{
	class Program
	{
		static void Main(string[] args)
		{
			String choice = "y";
			while (choice.Equals  ("y"))
			{
				Console.WriteLine("Welcome to the tempurature converter");
				Console.Write("Enter degrees in Fahrenheit: ");
				String far = Console.ReadLine();
				Double tempfar = Convert.ToDouble(far);

				Double cel = (tempfar - 32) * 5 / 9;
				Double cel1 = Math.Round(cel, 1);
				Console.WriteLine("Degrees in Celcius: " + cel1);

				Console.WriteLine("Continue? (y/n): ");
				choice = Console.ReadLine();
			}
			Console.WriteLine("Bye!");
		} 
		
	}
}
