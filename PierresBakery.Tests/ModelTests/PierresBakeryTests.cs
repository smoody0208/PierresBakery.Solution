using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Model;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void AddBreadItem_ForOneItem_One()
    {
      int amount = 1;
      int result = Bread.AddBreadCost(amount);
      Assert.AreEqual(result, 5);
    }

    [TestMethod]
    public void AddBreadItem_ForThreeItem_One()
    {
      int amount = 3;
      int result = Bread.AddBreadCost(amount);
      Assert.AreEqual(result, 15);
    }

  }
}