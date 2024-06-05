using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]

        public void OrderListOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the propert
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>(); 
            //Add an Item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its ptoperties
            TestItem.Stock = true;
            TestItem.OrderId = 1;
            TestItem.OrderSummary = "Standard E ticket Row A 1-3";
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderNo = "5";
            TestItem.Price = "450";
            TestItem.OrderColour = "Red";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]    

        public void CountPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 1;
            //assign the data to the property
            AllOrders.Count = SomeCount;
            //test to see that two values are the same
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }

        [TestMethod]

        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.Stock = true;
            TestOrder.OrderId = 1;
            TestOrder.OrderSummary = "Standard E ticket Row A 1-3";
            TestOrder.DateAdded = DateTime.Now; 
            TestOrder.OrderNo = "5";
            TestOrder.Price = "450";
            TestOrder.OrderColour = "Red";
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]

        public void ListandCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Stock = true;
            TestItem.OrderId = 1;
            TestItem.OrderSummary = "Standard E ticket Row A 1-3";
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderNo = "5";
            TestItem.Price = "450";
            TestItem.OrderColour = "Red";
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]    

        public void TwoRecordsPresent()
        {
            //create an instance of the vlass we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.Count, 1);
        }

    }
}
