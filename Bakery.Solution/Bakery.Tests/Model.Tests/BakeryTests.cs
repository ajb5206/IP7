using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests 
{
	[TestClass]
	public class BreadTests
	{
		[TestMethod]
		public void BreadCost_ReturnsCostTimesAmount_Five()
		{
			Bread testBread = new Bread();
			Assert.AreEqual(5, testBread.BreadCost(1));
		}
		[TestMethod]
		public void BreadCost_ReturnsCostTimesAmountUpdated_FortyFive()
		{
			Bread testBread = new Bread();
			Assert.AreEqual(45, testBread.BreadCost(13));
		}
	}
	[TestClass]
	public class PastryTests
	{
		[TestMethod]
		public void PastryCost_ReturnsCostTimesAmount_Two()
		{
			Pastry testPastry = new Pastry();
			Assert.AreEqual(2, testPastry.PastryCost(1));
		}
	}
}