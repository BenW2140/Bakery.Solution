using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryPrice_ReturnPriceOfPastry_Float()
    {
      Pastry pastry = new Pastry(1);
      Assert.AreEqual(2, pastry.Price);
    }
    [TestMethod]
    public void PastryQuantity_ReturnNumberOfPastries_Int()
    {
      Pastry pastries = new Pastry(5);
      Assert.AreEqual(5, pastries.Quantity);
    }
    [TestMethod]
    public void PastryTotal_ReturnTotalPriceOfPastries_Float()
    {
      Pastry pastries = new Pastry(2);
      Assert.AreEqual(4, pastries.TotalPrice);
    }
    [TestMethod]
    public void PastryDeal_ReturnTotalAfterDealApplied_Float()
    {
      Pastry pastries = new Pastry(3);
      pastries.PastryDeal();
      Assert.AreEqual(6, pastries.TotalPrice);
    }
  }
}