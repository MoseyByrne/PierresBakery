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
      int sourdoughResponse = 1;
      int breadCost = 5;
      Bread newBread = new Bread(sourdoughResponse);
      Assert.AreEqual(breadCost, newBread.BreadCost());
    }

    [TestMethod]
    public void BreadCost_CostOfTwoLoaves_Int()
    {
      int sourdoughResponse = 2;
      int breadCost = 10;
      Bread newBread = new Bread(sourdoughResponse);
      Assert.AreEqual(breadCost, newBread.BreadCost());
    }

    [TestMethod]
    public void BreadCost_ThirdLoafIsFree_Int()
    {
      int sourdoughResponse = 3;
      int breadCost = 10;
      Bread newBread = new Bread(sourdoughResponse);
      Assert.AreEqual(breadCost, newBread.BreadCost());
    }

    [TestMethod]
    public void BreadCost_CostOfFourLoaves_Int()
    {
      int sourdoughResponse = 4;
      int breadCost = 15;
      Bread newBread = new Bread(sourdoughResponse);
      Assert.AreEqual(breadCost, newBread.BreadCost());
    }


    [TestMethod]
    public void BreadCost_SixthLoafIsFree_Int()
    {
      int sourdoughResponse = 6;
      int breadCost = 20;
      Bread newBread = new Bread(sourdoughResponse);
      Assert.AreEqual(breadCost, newBread.BreadCost());
    }

        [TestMethod]
    public void SproutedCost_CostOneLoaf_Int()
    {
      int sproutedResponse = 1;
      int sproutedCost = 6;
      Bread newBread = new Bread(sproutedResponse);
      Assert.AreEqual(sproutedCost, newBread.SproutedCost());
    }

    [TestMethod]
    public void BreadCost_CostOfTwoLoaves_Int()
    {
      int sproutedResponse = 2;
      int sproutedCost = 12;
      Bread newBread = new Bread(sproutedResponse);
      Assert.AreEqual(sproutedCost, newBread.SproutedCost());
    }
  }
}