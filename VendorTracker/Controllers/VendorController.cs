using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> VendorsList = Vendor.GetAll();
      return View(VendorsList);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDesc)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDesc);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{vendorId}")]
    public ActionResult show(int vendorId)
    {
      Dictionary <string, object> model = new Dictionary<string, object> ();
      Vendor selectedVendor = Vendor.Find(vendorId);
      List <Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }
  }
}