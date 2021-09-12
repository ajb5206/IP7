using System;

namespace Bakery.Models
{
	public class Bread
	{
		private int _breadCost;

		public Bread(int bAmount)
		{
			if (bAmount < 3)
			{
				_breadCost = (5 * bAmount);
			}
			else
			{
				_breadCost = (5 * (bAmount - ((bAmount - bAmount%3)/3)));
			}
		}

		public int GetBreadTotal()
		{
			return _breadCost;
		}
	}

	public class Pastry
	{
		private int _pastryCost;

		public Pastry(int pAmount)
		{
			if (pAmount < 3)
			{
				 _pastryCost = pAmount * 2;
			}
			else if (pAmount == 3)
			{
				_pastryCost = 5;
			}
			else if (pAmount == 4)
			{
				_pastryCost = 7;
			}
			else if (pAmount == 5)
			{
				_pastryCost = 9;
			}
			else if (pAmount == 6)
			{
				_pastryCost = 10;
			}
			else if (pAmount >= 6)
			{
				_pastryCost = pAmount * 2;
			}
		}

		public int GetPastryTotal()
		{
			return _pastryCost;
		}
	}
}