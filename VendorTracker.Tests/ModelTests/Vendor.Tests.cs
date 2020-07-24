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
      Vendor testVendor = new Vendor("Kenny");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
    [TestMethod]
    public void VendorName_ProperlySetVendorNameAndGetProperty_String()
    {
      string testName = "Kenny";
      Vendor testVendor = new Vendor(testName);
      string propertyName = testVendor.Name;
      Assert.AreEqual(testName, propertyName);
    }
  }
}