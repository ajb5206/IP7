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
			else if (bAmount % 3 == 0)
			{
				return (5 * (bAmount - (bAmount/3)));
			}
			else
			{
				return (5 * (bAmount - ((bAmount - bAmount%3)/3)));
			}
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