using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void AddTestItem_ForOneItem_One()
    {
      Pastry PastryItem = new Pastry(1);
      int result = 2;
      Assert.AreEqual(result, PastryItem.AddPastryItem());
    }

    [TestMethod]
    public void AddTestItem_DiscountPastryItem_3()
    {
      Pastry PastryItem = new Pastry(3);
      int result = 5;
      Assert.AreEqual(result, PastryItem.AddPastryItem());
    }
  }   
}