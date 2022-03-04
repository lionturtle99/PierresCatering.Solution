using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string title = "test title";
      string description = "test description";
      string date = "02/04/2022";
      int price = 250;
      Order testOrder = new Order(title, description, date, price);
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string title = "test title";
      string description = "test description";
      string date = "02/04/2022";
      int price = 250;
      Order testOrder = new Order(title, description, date, price);
      string result = testOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> testList = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(testList, result);
    }


  }
}