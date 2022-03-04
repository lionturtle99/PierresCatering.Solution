using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string name = "test name";
      string description = "test";
      Vendor testVendor = new Vendor(name, description);

      string updatedDescription = "updated test";
      testVendor.Description = updatedDescription;
      string result = testVendor.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      List<Vendor> testList = new List<Vendor> { };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendor_VendorList()
    {
      string name = "test name";
      string description = "test description";
      string name0 = "Coffee shop wants cookies";
      string description0 = "cookies";
      Vendor testVendor = new Vendor(name, description);
      Vendor testVendor0 = new Vendor(name0, description0);
      List<Vendor> testList = new List<Vendor> { testVendor, testVendor0 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void GetId_VendorsInstantiateWithAnIdAndGetterReturns_Int()
    {
      string name = "test";
      string description = "test";
      Vendor testVendor = new Vendor(name, description);
      int result = testVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name = "test name";
      string description = "test description";
      string name0 = "Coffee shop wants cookies";
      string description0 = "cookies";
      Vendor testVendor = new Vendor(name, description);
      Vendor testVendor0 = new Vendor(name0, description0);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(testVendor0, result);
    }
  }
}