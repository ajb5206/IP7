using System;

namespace Bakery
{
	public class Bread
	{
		public int BreadCost(int bAmount)
		{
			if(bAmount < 3)
			{
				return (5 * bAmount);
			}
			else
			{
				return (5 * (bAmount - ((bAmount - bAmount%3)/3)));
			}
		}
	}

	public class Pastry
	{
		public int? PastryCost(int pAmount)
		{
			if (pAmount < 3)
			{
				return pAmount * 2;
			}
			else if (pAmount == 3)
			{
				return 5;
			}
			else if (pAmount == 4)
			{
				return 7;
			}
			else if (pAmount == 5)
			{
				return 9;
			}
			else if (pAmount == 6)
			{
				return 10;
			}
			else
			{
				return null;
			}
		}
	}
}