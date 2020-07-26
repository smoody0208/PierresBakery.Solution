using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryBread.Model;
using BakeryPastry.Model;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void AddBreadItem_ForOneItem_One()
    {
      Bread BreadItem = new Bread(1);
      int result = 5;
      Assert.AreEqual(result, BreadItem.AddBreadCost());
    }

    [TestMethod]
    public void AddBreadItem_ForThreeItem_Three()
    {
      Bread BreadItem = new Bread(4);
      int result = 15;
      Assert.AreEqual(result, BreadItem.AddBreadCost());
    }

    [TestMethod]
    public void AddBreadItemDiscount_ForThreeItem_Three()
    {
      Bread BreadItem = new Bread(3);
      int result = 10;
      Assert.AreEqual(result, BreadItem.AddBreadCost());
    }
  } 
}