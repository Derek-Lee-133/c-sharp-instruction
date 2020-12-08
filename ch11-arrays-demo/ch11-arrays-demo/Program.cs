using System;

namespace ch11_arrays_demo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("arrays demo");
			string[] names = { "chris", "josh", "derek", "monroe" };
			Console.WriteLine("element at position 1: " + names[1]);

			// idexed loop
			for (int i = 0; i < names.Length; i++)
			{
				Console.WriteLine(names[i]);
				






				Console.WriteLine("bye");
			}
			foreach (string name in names)
			{
				Console.WriteLine(name);
			}
		}
	}
}
