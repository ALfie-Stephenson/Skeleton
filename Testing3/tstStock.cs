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
            DateTime TestData = Convert.ToDateTime("15/05/2024");
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
            Int32 TestData = 6;
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
            String TestData = "Preston VS MKDons" ;
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
            string TestData = "AwayC";
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
            Int32 TestData = 25;
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
            Int32 TestData = 15;
            //assign the data to the property
            Stock.TicketPrice = TestData;
            //test to see that the two value are the same
            Assert.AreEqual(Stock.TicketPrice, TestData);
        }
        [TestMethod]
        public void TestStockIDFound()
        {
            //create an instance of the class we want to create 
            clsStock Stock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StockID = 6;
            //invoke the method
            Found = Stock.Find(StockID);
            //check the stock id 
            if (Stock.StockID != 6)
            {
                OK = false; 
            }
            //test to see if the result is true 
            Assert.IsTrue(OK); 
        }
        [TestMethod]
        public void TestGameIDFound()
        {
            //create an instance of the class we want to create 
            clsStock Stock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StockID = 6;
            //invoke the method
            Found = Stock.Find(StockID);
            //check the Game id 
            if (Stock.GameID != "Preston VS MKDons")
            {
                OK = false;
            }
            //test to see if the result is true 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTicketLocationFound()
        {
            //create an instance of the class we want to create 
            clsStock Stock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StockID = 6;
            //invoke the method
            Found = Stock.Find(StockID);
            //check the ticket location  
            if (Stock.TicketLocation != "AwayC")
            {
                OK = false;
            }
            //test to see if the result is true 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockAmountFound()
        {
            //create an instance of the class we want to create 
            clsStock Stock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StockID = 6;
            //invoke the method
            Found = Stock.Find(StockID);
            //check the stock amount 
            if (Stock.StockAmount != 25)
            {
                OK = false;
            }
            //test to see if the result is true 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTicketPriceFound()
        {
            //create an instance of the class we want to create 
            clsStock Stock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StockID = 6;
            //invoke the method
            Found = Stock.Find(StockID);
            //check the ticket price  
            if (Stock.TicketPrice != 15)
            {
                OK = false;
            }
            //test to see if the result is true 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTimeTicketsGoOnSaleFound()
        {
            //create an instance of the class we want to create 
            clsStock Stock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StockID = 6;
            //invoke the method
            Found = Stock.Find(StockID);
            //check the time tickets go on sale
            if (Stock.TimeTicketsGoOnSale !=Convert.ToDateTime("15/05/2024"))
            {
                OK = false;
            }
            //test to see if the result is true 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestInStockFound()
        {
            //create an instance of the class we want to create 
            clsStock Stock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StockID = 6;
            //invoke the method
            Found = Stock.Find(StockID);
            //check the stock id 
            if (Stock.InStock != true)
            {
                OK = false;
            }
            //test to see if the result is true 
            Assert.IsTrue(OK);
        }
    }
}

