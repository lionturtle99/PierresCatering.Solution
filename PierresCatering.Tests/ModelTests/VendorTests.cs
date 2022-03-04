using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      string name = "test name";
      string description = "test description";
      Vendor testVendor = new Vendor(name, description);
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
    
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "test name";
      string description = "test description";
      Vendor testVendor = new Vendor(name, description);
      string result = testVendor.Description;
      Assert.AreEqual("good fail", result);
    }
  }
}