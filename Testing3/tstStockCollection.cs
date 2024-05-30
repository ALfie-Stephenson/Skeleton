using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

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

        [TestMethod]

        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InStock = true;
            TestItem.StockID = 1;
            TestItem.GameID = "peterbrough VS Cambridge";
            TestItem.TicketLocation = "Grand G";
            TestItem.StockAmount = 25;
            TestItem.TicketPrice = 30;
            TestItem.TimeTicketsGoOnSale = DateTime.Now;
            //set this stock to test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestItem);

        }
        [TestMethod]

        public void UpdateMethodOk()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InStock = true;
            TestItem.StockID = 1;
            TestItem.GameID = "peterbrough VS Cambridge";
            TestItem.TicketLocation = "Grand G";
            TestItem.StockAmount = 25;
            TestItem.TicketPrice = 30;
            TestItem.TimeTicketsGoOnSale = DateTime.Now;
            //set this stock to test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            //set its properties
            TestItem.InStock = false;
            TestItem.StockID = 1;
            TestItem.GameID = "Leicester VS Leeds";
            TestItem.TicketLocation = "Away G";
            TestItem.StockAmount = 55;
            TestItem.TicketPrice = 45;
            TestItem.TimeTicketsGoOnSale = DateTime.Now;
            //set this stock to test data
            AllStocks.ThisStock = TestItem;
            //add the record
            AllStocks.Update();
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }
        [TestMethod]

        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InStock = true;
            TestItem.StockID = 1;
            TestItem.GameID = "peterbrough VS Cambridge";
            TestItem.TicketLocation = "Grand G";
            TestItem.StockAmount = 25;
            TestItem.TicketPrice = 30;
            TestItem.TimeTicketsGoOnSale = DateTime.Now;
            //set this stock to test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStocks.Delete();
            //now find the record 
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse( Found );

        }
        [TestMethod]

        public void ReportByGameIDMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStocks = new clsStockCollection();
            //create an instance of the filtered data   
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a blank string (should return all records);
            FilteredStocks.ReportByGameID("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count );
        }
        [TestMethod]

        public void ReportByGameIDNoneFound()
        {
            //create an instance of the class we want to create
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a post code that doesnt exist
            FilteredStocks.ReportByGameID("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            //test to see that there are no records 
            Assert.AreEqual(0, FilteredStocks.Count);
        }
        [TestMethod]

        public void ReportByGameIDTestDataFound()
        {
            //create an instance of the class we want to create
            clsStockCollection FilteredStocks = new clsStockCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a post code that doesnt exist
            FilteredStocks.ReportByGameID("Port Vale VS Farrow");
            //check that the correct number of records are found
            if (FilteredStocks.Count == 2) 
            {
                //check to see that the first record is 1038
                if (FilteredStocks.StockList[0].StockID != 1038)
                {
                    OK = false;
                }
                //check to see that the first record is 1039
                if (FilteredStocks.StockList[1].StockID != 1039)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
            
        }
    }
}
