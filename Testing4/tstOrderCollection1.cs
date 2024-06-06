﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection1
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection1 AllOrders = new clsOrderCollection1();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]

        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection1 AllOrders = new clsOrderCollection1();
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

        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to creatwe 
            clsOrderCollection1 AllOrders = new clsOrderCollection1();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test project
            TestOrder.Stock = true;
            TestOrder.OrderId = 1;
            TestOrder.OrderSummary = "Standard E ticket Row A 1-3";
            TestOrder.DateAdded = DateTime.Now;
            TestOrder.OrderColour = "Red";
            TestOrder.Price = "450";
            TestOrder.OrderNo = "5";    
            //assign data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]

        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection1 AllOrders = new clsOrderCollection1();
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

        
    }
    }