using ClassLibrary;
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

        [TestMethod]

        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection1 AllOrders = new clsOrderCollection1();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Stock = true;
            TestItem.OrderId = 1;
            TestItem.OrderSummary = "Standard E ticket Row A 1-3";
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderNo = "5";
            TestItem.Price = "450";
            TestItem.OrderColour = "Red";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of test data
            TestItem.OrderId = PrimaryKey;
            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            //create an imstance of the class we want to create
            clsOrderCollection1 AllOrders = new clsOrderCollection1();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Stock = true;
            TestItem.OrderId = 1;
            TestItem.OrderSummary = "Standard E ticket Row A 1-3";
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderNo = "5";
            TestItem.Price = "450";
            TestItem.OrderColour = "Red";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data 
            TestItem.OrderId = PrimaryKey;
            //modify the test record
            TestItem.Stock = false;
            TestItem.OrderId = 1;
            TestItem.OrderSummary = "Standard E ticket Row Z 2-5 ";
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderNo = "6";
            TestItem.Price = "455";
            TestItem.OrderColour = "Blue";
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see if ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection1 AllOrders = new clsOrderCollection1();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Stock = true;
            TestItem.OrderId = 1;
            TestItem.OrderSummary = "Standard E ticket Row A 1-3";
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderNo = "5";
            TestItem.Price = "450";
            TestItem.OrderColour = "Red";
            //ser ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse( Found );

        }

        [TestMethod]

        public void ReportByOrderNoMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection1 AllOrders = new clsOrderCollection1();
            //create an instance of the filtered data
            clsOrderCollection1 FilteredOrders = new clsOrderCollection1();
            //apply a blank string (it should return all records)
            FilteredOrders.ReportByOrderNo("");
            //test to see that the two values are th same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]

        public void ReportByOrderNoNoneFound()
        {
            //create an instance of the class we want to create
            clsOrderCollection1 FilteredOrders = new clsOrderCollection1(); ;
            //apply a post code that doesnt exist
            FilteredOrders.ReportByOrderNo("xxx xxx");
            //test to see that there are no records 
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]

        public void ReportByOrderNoTestDataFound()
        {
            //create an instance of the filtered data 
            clsOrderCollection1 FilteredOrders = new clsOrderCollection1();
            //variable to store the outcome
            Boolean OK = true;
            //apply an OrderNO that doesnt exist
            FilteredOrders.ReportByOrderNo("yyy yyy");
            //check that the current number of records are found
            if(FilteredOrders.OrderList.Count == 2)
            {
                //check to see that the first record is 25
                if (FilteredOrders.OrderList[0].OrderId != 25)
                {
                    OK = false;
                }
                //check to see that the first record is 26
                if (FilteredOrders.OrderList[1].OrderId != 26)
                {
                    OK = false;
                }
            }
            else
            {
                //test to see that there are no records 
                Assert.IsTrue(OK);
            }
        }

        


    }
    }
