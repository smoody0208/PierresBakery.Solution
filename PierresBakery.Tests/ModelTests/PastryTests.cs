using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void AddTestItem_ForOneItem_int()
    {
      Pastry PastryItem = new Pastry(1);
      int result = 2;
      Assert.AreEqual(result, PastryItem.AddPastryItem());
    }

    [TestMethod]
    public void AddTestItem_DiscountPastryItem_int()
    {
      Pastry PastryItem = new Pastry(3);
      int result = 5;
      Assert.AreEqual(result, PastryItem.AddPastryItem());
    }

    [TestMethod]
    public void AddTestItem_FourPastryItems_int() 
    {
      Pastry PastryItem = new Pastry(4);
      int result = 7;
      Assert.AreEqual(result, PastryItem.AddPastryItem());
    }
  }   
}