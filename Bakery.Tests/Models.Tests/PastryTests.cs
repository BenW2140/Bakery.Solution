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
  }
}