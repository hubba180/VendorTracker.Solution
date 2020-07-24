using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor selectedVendor = Vendor.Find(vendorId);
      return View(selectedVendor);
    }
    // [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    // public ActionResult Show(int vendorId, int orderId)
    // {
    //   Vendor assocVendor = Vendor.Find(vendorId);
    //   Order selectedOrder = Order.Find(orderId);
    // }
  }
}