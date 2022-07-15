using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadCost_CostOneLoaf_Int()
    {
      int loafResponse = 1;
      int breadCost = 5;
      Bread newBread = new Bread(loafResponse);
      Assert.AreEqual(breadCost, newBread.BreadCost());
    }

    [TestMethod]
    public void BreadCost_CostOfTwoLoaves_Int()
    {
      int loafResponse = 2;
      int breadCost = 10;
      Bread newBread = new Bread(loafResponse);
      Assert.AreEqual(breadCost, newBread.BreadCost());
    }

    [TestMethod]
    public void BreadCost_ThirdLoafIsFree_Int()
    {
      int loafResponse = 3;
      int breadCost = 10;
      Bread newBread = new Bread(loafResponse);
      Assert.AreEqual(breadCost, newBread.BreadCost());
    }

    [TestMethod]
    public void BreadCost_CostOfFourLoaves_Int()
    {
      int loafResponse = 4;
      int breadCost = 15;
      Bread newBread = new Bread(loafResponse);
      Assert.AreEqual(breadCost, newBread.BreadCost());
    }


    [TestMethod]
    public void BreadCost_SixthLoafIsFree_Int()
    {
      int loafResponse = 6;
      int breadCost = 20;
      Bread newBread = new Bread(loafResponse);
      Assert.AreEqual(breadCost, newBread.BreadCost());
    }
  }
}