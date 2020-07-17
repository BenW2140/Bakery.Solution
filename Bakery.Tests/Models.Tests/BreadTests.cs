using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadPrice_ReturnPriceOfBread_Float()
    {
      Bread loaf = new Bread(1);
      Assert.AreEqual(5, loaf.Price);
    }
    [TestMethod]
    public void BreadQuantity_ReturnNumberOfLoaves_Int()
    {
      Bread loaves = new Bread(3);
      Assert.AreEqual(3, loaves.Quantity);
    }
    [TestMethod]
    public void BreadTotal_ReturnTotalPriceOfBread_Float()
    {
      Bread loaves = new Bread(2);
      Assert.AreEqual(10, loaves.TotalPrice);
    }
  }
}