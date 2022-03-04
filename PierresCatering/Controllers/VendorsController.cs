using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      Console.WriteLine("It made it to VendorController.cs");
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
  }
}