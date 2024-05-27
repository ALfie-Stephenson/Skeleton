﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStocks);
        }
        [TestMethod]

        public void StockListOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list 
            //create the item of test data 
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.InStock = true;
            TestItem.StockID = 1;
            TestItem.GameID = "peterbrough VS Cambridge";
            TestItem.TicketLocation = "Grand G";
            TestItem.StockAmount = 25;
            TestItem.TicketPrice = 30;
            TestItem.TimeTicketsGoOnSale = DateTime.Now;
            //add the time to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.StockList, TestList);


        }
     //   [TestMethod]

       // public void CountPropertyOK()
       // {
       //     //create instance pof the class we want to create 
       //     clsStockCollection AllStocks = new clsStockCollection();
        //    //create some test data to assign to the property
        //    Int32 SomeCount = 2;
       //     //assign the data to the property 
       //     AllStocks.Count = SomeCount;
       //     //test to see that the two values are the same
       //     Assert.AreEqual(AllStocks.Count, SomeCount);
      //  }
        [TestMethod]

        public void ThisStockPropertyOk()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set its properties
            TestStock.InStock = true;
            TestStock.StockID = 1;
            TestStock.GameID = "peterbrough VS Cambridge";
            TestStock.TicketLocation = "Grand G";
            TestStock.StockAmount = 25;
            TestStock.TicketPrice = 30;
            TestStock.TimeTicketsGoOnSale = DateTime.Now;
            //assign the data to the property
            AllStocks.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }
        [TestMethod]

        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list 
            //create the item of test data 
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.InStock = true;
            TestItem.StockID = 1;
            TestItem.GameID = "peterbrough VS Cambridge";
            TestItem.TicketLocation = "Grand G";
            TestItem.StockAmount = 25;
            TestItem.TicketPrice = 30;
            TestItem.TimeTicketsGoOnSale = DateTime.Now;
            //add the time to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, TestList.Count);

        }
     //   [TestMethod]
     //   public void TwoRecordPresent()
     //   {
            //create an instance of the class we want to create
     //       clsStockCollection AllStocks = new clsStockCollection();
            //test to see that the two values are the same
     //       Assert.AreEqual(AllStocks.Count, 2);
     //   }
    }
}