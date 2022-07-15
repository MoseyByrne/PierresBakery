using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class SpecialTests
  {
    
    [TestMethod]
    public void SpecialCost_CostOneSpecial_Int()
    {
      int specialResponse = 1;
      int specialCost = 4;
      
      Special newSpecial = new Special (specialResponse);
      Assert.AreEqual(specialCost, newSpecial.SpecialCost());
    }

        [TestMethod]
    public void SpecialCost_CostFiveSpecial_Int()
    {
      int specialResponse = 5;
      int specialCost = 20;
      
      Special newSpecial = new Special (specialResponse);
      Assert.AreEqual(specialCost, newSpecial.SpecialCost());
    }
  }
}
