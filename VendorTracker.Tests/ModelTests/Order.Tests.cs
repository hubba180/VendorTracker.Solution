using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;

namespace VendorTracker.Test
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_InstantiateNewOrderObject_Order()
    {
      Order testOrder = new Order("bread", 2, "7/24/2020");
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
    [TestMethod]
    public void GetPropertyTypes_InstantiateTypeAndQuantity_StringAndNumber()
    {
      Order testOrder = new Order("Bread", 2, "7/24/2020");
      string type = "Bread";
      int quantity = 2;
      string date = "7/24/2020";
      Assert.AreEqual(type, testOrder.Type);
      Assert.AreEqual(quantity, testOrder.Quantity);
      Assert.AreEqual(date, testOrder.Date);
    }
    [TestMethod]
    public void Price_CalculateOrderPrice_Int()
    {
      Order breadOrder = new Order("Bread", 6, "7/24/2020");
      Order pastryOrder = new Order("Pastry", 6, "7/24/2020");
      int answer1 = 20;
      int answer2 = 10;
      Assert.AreEqual(answer1, breadOrder.Price());
      Assert.AreEqual(answer2, pastryOrder.Price());
    }
    [TestMethod]
    public void GetAll_ReturnStaticListForOrders_List()
    {
      List<Order> testList = Order.GetAll();
      List<Order> result = new List<Order> {};
      CollectionAssert.AreEqual(testList, result);
    }
    [TestMethod]
    public void Find_FindOrderWithIdInStaticList_Order()
    {
      Order testOrder = new Order("Bread", 2, "7/24/2020");
      int testOrderId = testOrder.Id;
      Order findbyId = Order.Find(testOrderId);
      Assert.AreEqual(testOrder, findbyId);
    }
  }
}