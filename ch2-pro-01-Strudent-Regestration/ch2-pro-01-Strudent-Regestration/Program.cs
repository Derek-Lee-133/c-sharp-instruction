using System;

namespace ch2_pro_01_Strudent_Regestration
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Student Regestration");

			Console.Write("Enter first name: ");
			String firstName = Console.ReadLine();
			Console.Write("Enter last name: ");
			String lastName = Console.ReadLine();
			Console.Write("Enter year of birth: ");
			String yob = Console.ReadLine();

			Console.WriteLine("Welcome " + firstName + " " + lastName + "!");
			Console.WriteLine("Your regestration is complete. ");
			Console.WriteLine("Your temporary password is: " + firstName + "*" + yob);

		}
	}
}
