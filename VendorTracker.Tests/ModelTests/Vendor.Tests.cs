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
      Vendor testVendor = new Vendor("Kenny", "Great Food!");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
    [TestMethod]
    public void VendorName_ProperlySetVendorNameAndGetProperty_String()
    {
      string testName = "Kenny";
      string testDescription = "Great Food!";
      Vendor testVendor = new Vendor(testName, testDescription);
      string propertyName = testVendor.Name;
      Assert.AreEqual(testName, propertyName);
    }
    [TestMethod]
    public void VendorDescription_ProperlySetVendorDescriptionAndGetProperty_String()
    {
      string testName = "Kenny";
      string testDescription = "Great Food!";
      Vendor testVendor = new Vendor(testName, testDescription);
      string propertyDescription = testVendor.Description;
      Assert.AreEqual(testDescription, propertyDescription);
    }
    [TestMethod]
    public void ResetVendorName_ResetAVendorsName_String()
    {
      string testName = "Kenny";
      string testDescription = "Great Food!";
      string resetName = "George";
      Vendor testVendor = new Vendor(testName, testDescription);
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