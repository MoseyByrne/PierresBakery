using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    
    [TestMethod]
    public void PastryCost_CostOnePastry_Int()
    {
      int pastryResponse = 1;
      int pastryCost = 2;
      Pastry newPastry = new Pastry (pastryResponse);
      Assert.AreEqual(pastryCost, newPastry.PastryCost());
    }


    [TestMethod]
    public void PastryCost_CostOfTwoPastries_Int()
    {
      int pastryResponse = 2;
      int pastryCost = 4;
      Pastry newPastry = new Pastry(pastryResponse);
      Assert.AreEqual(pastryCost, newPastry.PastryCost());
    }

    [TestMethod]
    public void PastryCost_ThirdPastryIsFree_Int()
    {
      int pastryResponse = 3;
      int pastryCost = 5;
      Pastry newPastry = new Pastry(pastryResponse);
      Assert.AreEqual(pastryCost, newPastry.PastryCost());
    }

    [TestMethod]
    public void PastryCost_CostOfFourPastries_Int()
    {
      int pastryResponse = 4;
      int pastryCost = 7;
      Pastry newPastry = new Pastry(pastryResponse);
      Assert.AreEqual(pastryCost, newPastry.PastryCost());
    }


    [TestMethod]
    public void PastryCost_SixthPastryIsFree_Int()
    {
      int pastryResponse = 6;
      int pastryCost = 10;
      Pastry newPastry = new Pastry(pastryResponse);
      Assert.AreEqual(pastryCost, newPastry.PastryCost());
    }
  }
}