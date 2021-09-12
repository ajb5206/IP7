using System;

namespace Bakery.Models
{
	public class Bread
	{
		public int BreadCost { get; }

		public Bread(int bAmount)
		{
			if (bAmount < 3)
			{
				BreadCost = (5 * bAmount);
			}
			else
			{
				BreadCost = (5 * (bAmount - ((bAmount - bAmount%3)/3)));
			}
		}

		// public int GetBreadTotal()
		// {
		// 	return _breadCost;
		// }
	}

	public class Pastry
	{
		public int PastryCost { get; }

		public Pastry(int pAmount)
		{
			if (pAmount < 3)
			{
				 PastryCost = pAmount * 2;
			}
			else if (pAmount == 3)
			{
				PastryCost = 5;
			}
			else if (pAmount == 4)
			{
				PastryCost = 7;
			}
			else if (pAmount == 5)
			{
				PastryCost = 9;
			}
			else if (pAmount == 6)
			{
				PastryCost = 10;
			}
			else if (pAmount >= 6)
			{
				PastryCost = pAmount * 2;
			}
		}

		// public int GetPastryTotal()
		// {
		// 	return _pastryCost;
		// }
	}
}