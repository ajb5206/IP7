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
			int pAmount = int.Parse(pastries);
			if (userPastry.PastryCost(pAmount) == null )
			{
				Console.WriteLine("I'm sorry, we do not have that many pastries left!");
				Console.WriteLine("Please choose 6 or fewer pastries");
				Console.WriteLine("\r\n\r\n");
				Main();
			}
			else
			{
					Console.WriteLine($"Your total is ${userPastry.PastryCost(pAmount) + userBread.BreadCost(bAmount)}, thank you!");
			}
		}
	}
}