using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;

namespace VendorTracker.Test
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_InstantiateNewOrderObject_Order()
    {
      Order testOrder = new Order("bread", 2);
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
    [TestMethod]
    public void GetPropertyTypes_InstantiateTypeAndQuantity_StringAndNumber()
    {
      Order testOrder = new Order("Bread", 2);
      string type = "Bread";
      int quantity = 2;
      Assert.AreEqual(type, testOrder.Type);
      Assert.AreEqual(quantity, testOrder.Quantity);
    }
  }
}