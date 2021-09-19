using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests 
{
	[TestClass]
	public class BreadTests
	{
		[TestMethod]
		public void BreadConstructor_CreatesInstanceOfBread_Loaves()
		{
			Bread testBread = new Bread(1);
			Assert.AreEqual(typeof(Bread), testBread.GetType());
		}
		[TestMethod]
		public void BreadCost_ReturnsCostTimesAmount_Five()
		{
			Bread testBread = new Bread(1);
			Assert.AreEqual(5, testBread.BreadCost);
		}
		[TestMethod]
		public void BreadCost_ReturnsCostTimesAmountUpdated_FortyFive()
		{
			Bread testBread = new Bread(13);
			Assert.AreEqual(45, testBread.BreadCost);
		}
	}
	[TestClass]
	public class PastryTests
	{
		[TestMethod]
		public void PastryConstructor_CreatesInstanceOfPastry_Pastries()
		{
			Pastry testPastry = new Pastry(1);
			Assert.AreEqual(typeof(Pastry), testPastry.GetType());
		}
		[TestMethod]
		public void PastryCost_ReturnsCostTimesAmount_Two()
		{
			Pastry testPastry = new Pastry(1);
			Assert.AreEqual(2, testPastry.PastryCost);
		}
		[TestMethod]
		public void PastryCost_ReturnsCostForFivePastries_Nine()
		{
			Pastry testPastry = new Pastry(5);
			Assert.AreEqual(9, testPastry.PastryCost);
		}
		[TestMethod]
		public void PastryCost_ReturnsDoubleIfGreaterThanSix_DoubleInput()
		{
			Pastry testPastry = new Pastry(8);
			Assert.AreEqual(16, testPastry.PastryCost);
		}
	}
}