using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/Vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/Vendors")]
    public ActionResult Create(string vendorName, string descritpion)
    {
      Vendor newVendor = new Vendor(vendorName, descritpion);
      return RedirectToAction("Index");
    }

    [HttpGet("/categories/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }
  }
}