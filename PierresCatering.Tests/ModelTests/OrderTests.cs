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
    public void SetDescription_SetDescription_String()
    {
      string title = "test title";
      string description = "test description";
      string date = "02/04/2022";
      int price = 250;
      Order testOrder = new Order(title, description, date, price);

      string updatedDescription = "updated test";
      testOrder.Description = updatedDescription;
      string result = testOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> testList = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title = "test title";
      string description = "test description";
      string date = "02/04/2022";
      int price = 250;
      string title0 = "Coffee shop wants cookies";
      string description0 = "cookies";
      string date0 = "02/04/1999";
      int price0 = 50;
      Order testOrder = new Order(title, description, date, price);
      Order testOrder0 = new Order(title0, description0, date0, price0);
      List<Order> testList = new List<Order> { testOrder, testOrder0 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "test title";
      string description = "test description";
      string date = "02/04/2022";
      int price = 250;
      Order testOrder = new Order(title, description, date, price);

      int result = testOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title = "test title";
      string description = "test description";
      string date = "02/04/2022";
      int price = 250;
      string title0 = "Coffee shop wants cookies";
      string description0 = "cookies";
      string date0 = "02/04/1999";
      int price0 = 50;
      Order testOrder = new Order(title, description, date, price);
      Order testOrder0 = new Order(title0, description0, date0, price0);
      Order result = Order.Find(2);
      Assert.AreEqual(testOrder0, result);
    }
  }
}