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
      Bread loaf = new Bread();
      Assert.AreEqual(5, loaf.Price);
    }
  }
}