using Bakery.Models;
using System;

namespace Bakery
{
	public class Program
	{
		public static void Main()
		{
			Bread userBread = new Bread();
			Pastry userPastry = new Pastry();
			Console.WriteLine("Welcome to the bakery!");
			Console.WriteLine("How many loaves of bread would you like to buy?");
			string loaves = Console.ReadLine();
			int bAmount = int.Parse(loaves);
			Console.WriteLine("How many pastries would you like to buy?");
			string pastries = Console.ReadLine();
			int total = userBread.GetBreadTotal() + userPastry.GetPastryTotal();
			Console.WriteLine($"Your total is ${total}, thank you!");
			
		}
	}
}