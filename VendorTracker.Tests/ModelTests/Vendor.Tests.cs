using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;

namespace VendorTracker.Test
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
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
    [TestMethod]
    public void ResetVendorName_ResetAVendorsName_String()
    {
      string testName = "Kenny";
      string resetName = "George";
      Vendor testVendor = new Vendor(testName);
      testVendor.Name = resetName;
      string propertyName = testVendor.Name;
      Assert.AreEqual(resetName, propertyName);
    }
    [TestMethod]
    public void GetAll_ReturnStaticListForVendors_List()
    {
      List<Vendor> testList = Vendor.GetAll();
      List<Vendor> result = new List<Vendor> {};
      CollectionAssert.AreEqual(testList, result);
    }
  }
}