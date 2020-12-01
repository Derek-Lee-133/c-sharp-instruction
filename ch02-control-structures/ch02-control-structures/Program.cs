using System;

namespace ch02_control_structures
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Control Structure app!");
			String choice = "y";
			while (choice.Equals("y"))
			{

				
				Console.WriteLine("Enter color letter (r,g,b,p): ");
				String c = Console.ReadLine();
				if (c.Equals("r"))
				{
					Console.WriteLine("you picked red");
				}
				else if (c.Equals("g"))
				{
					Console.WriteLine("you picked green");
				}
				else if (c.Equals("b"))
				{
					Console.WriteLine("you picked blue");
				}
				else if (c.Equals("p")) {
					Console.WriteLine("you picked purple");
				}
				else
				{
					Console.WriteLine("incorrect color letter");
				}
				//  accept a numeric value

				Console.Write("Enter a whole number: ");
				int nbr = Int32.Parse(Console.ReadLine());
				Console.WriteLine("you entered # " + nbr);
				Console.WriteLine("Continue? ");
				choice = Console.ReadLine();





			}
			Console.WriteLine("Bye!");
		}
	}
}

