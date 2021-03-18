using System;

namespace ch12_2_wizard_inventory
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("The Wizard Inventory game!");
			Console.WriteLine("COMMAND MENU\nshow - Show all items\ngrab - Grab an item\nedit - Edit an item" +
				"\ndrop - Drop an item\nexit - Exit program" );
			String commmand = Console.ReadLine();


			String choice = "y";
			while (choice.Equals("y"))
			{


			}


			Console.WriteLine("Bye! Happy adventuring");
		}
	}
}
