using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //test to see that it exists 
            Assert.IsNotNull(Stock);
        }

        [TestMethod]
        public void InStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            Stock.InStock = TestData;
            //test to see that the two value are the same
            Assert.AreEqual(Stock.InStock, TestData);
        }
        [TestMethod]
        public void TimeTicketsGoOnSalePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Stock.TimeTicketsGoOnSale = TestData;
            //test to see that the two value are the same
            Assert.AreEqual(Stock.TimeTicketsGoOnSale, TestData);
        }
        [TestMethod]
        public void StockIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Stock.StockID = TestData;
            //test to see that the two value are the same
            Assert.AreEqual(Stock.StockID, TestData);
        }
        [TestMethod]
        public void GameIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Stock.GameID = TestData;
            //test to see that the two value are the same
            Assert.AreEqual(Stock.GameID, TestData);
        }
        [TestMethod]
        public void TicketLocationPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            string TestData = "GrandB";
            //assign the data to the property
            Stock.TicketLocation = TestData;
            //test to see that the two value are the same
            Assert.AreEqual(Stock.TicketLocation, TestData);
        }
        [TestMethod]
        public void StockAmountPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Stock.StockAmount = TestData;
            //test to see that the two value are the same
            Assert.AreEqual(Stock.StockAmount, TestData);
        }
        [TestMethod]
        public void TicketPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Stock.TicketPrice = TestData;
            //test to see that the two value are the same
            Assert.AreEqual(Stock.TicketPrice, TestData);
        }
    }
}

