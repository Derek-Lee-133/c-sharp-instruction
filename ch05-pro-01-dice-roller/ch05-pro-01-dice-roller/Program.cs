using System;

namespace ch05_pro_01_dice_roller
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Dice Roller!");
			String choice = "y";
			while (choice.Equals("y")) {
				var r = new Random();
				Console.Write("Roll the dice? (y/n): ");
					if (Console.ReadLine().Equals("y"))
					
					{ int dice1 = r.Next(1,6);
					int dice2 = r.Next(1, 6);
					int total = dice1 + dice2;
					if (total.Equals(12)) {
						Console.WriteLine("BOX CARS!");
					}if (total.Equals(2)) {
						Console.WriteLine("SNAKE EYES!");
							}
						Console.WriteLine("Die 1: " + dice1);
						Console.WriteLine("Die 2: " + dice2);
						Console.WriteLine("Total: " + total);
					

					}
				Console.WriteLine("Continue? (y/n): ");
				choice = (Console.ReadLine());
			}



				
			Console.WriteLine("Bye!");
		}
	}
			
	}

