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
    [TestMethod]
    public void Price_CalculateOrderPrice_Int()
    {
      Order breadOrder = new Order("Bread", 6);
      Order pastryOrder = new Order("Pastry", 6);
      int answer1 = 21;
      int answer2 = 11;
      Assert.AreEqual(answer1, breadOrder.Price());
      Assert.AreEqual(answer2, pastryOrder.Price());
    }
  }
}