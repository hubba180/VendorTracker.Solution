using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;

namespace VendorTracker.Test
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_ProperlyInstantiateVendor_Vendor()
    {
      Vendor testVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
  }
}