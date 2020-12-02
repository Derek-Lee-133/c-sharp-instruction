using System;

namespace ch03_pro02_travel_time_calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Travel Time Calculator!");
			String choice = "y";
			while (choice.Equals("y"))
			{
				Console.Write("Enter Miles: ");
				String dist = Console.ReadLine();
				Console.Write("Enter Miles Per Hour: ");
				String mph = Console.ReadLine();
				Double dist1 = Convert.ToDouble(dist);
				Double mph1 = Convert.ToDouble(mph);

			}
			Console.WriteLine("Bye!");
		}
	}
}
