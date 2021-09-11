using System;

namespace Bakery
{
	public class Bread
	{
		public int BreadCost(int bAmount)
		{
			return (5 * bAmount);
		}
	}

	public class Pastry
	{
		public int PastryCost(int pAmount)
		{
			return (2 * pAmount);
		}
	}
}