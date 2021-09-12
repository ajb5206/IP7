using Bakery.Models;
using System;

namespace Bakery
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Welcome to the bakery!");
			Console.WriteLine("How many loaves of bread would you like to buy?");
			string loaves = Console.ReadLine();
			int bAmount = int.Parse(loaves);
			Bread userBread = new Bread(bAmount);
			Console.WriteLine("How many pastries would you like to buy?");
			string pastries = Console.ReadLine();
			int pAmount = int.Parse(pastries);
			Pastry userPastry = new Pastry(pAmount);
			int total = userBread.GetBreadTotal() + userPastry.GetPastryTotal();
			Console.WriteLine($"Your total is ${total}, thank you!");
			
		}
	}
}