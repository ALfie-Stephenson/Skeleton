using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.IO.Pipes;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass the method
        string GameID = "PortVale vs Bristol";
        string TicketLocation = "Grand G";
        string StockAmount = "45";
        string TicketPrice = "34";
        string TimeTicketsGoOnSale = "03/09/2024";


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
            String TestData = "Preston VS MKDons";
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
            if (Stock.TimeTicketsGoOnSale != Convert.ToDateTime("15/05/2024"))
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
        [TestMethod]

        public void VaildMethodOK()
        {
            //create  an instance of the class we want to create 
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameIDMinLessOne()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string GameID = ""; //this should trigger an error
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GameIDMin()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string GameID = "a"; //this should be Ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameIDMinPlusOne()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string GameID = "aa"; //this should be ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameIDMaxLessOne()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string GameID = "";
            GameID = GameID.PadRight(49, 'a');//this should be ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameIDMax()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string GameID = "";
            GameID = GameID.PadRight(50, 'a');//this should be ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameIDMaxPlusOne()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string GameID = "";
            GameID = GameID.PadRight(51, 'a');//this should fail
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GameIDMid()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string GameID = "";
            GameID = GameID.PadRight(25, 'a');//this should be ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameIDExtremeMax()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string GameID = "";
            GameID = GameID.PadRight(500, 'a');//this should Fail
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TicketLocationMinLessOne()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TicketLocation = ""; //this should trigger an error
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TicketLocationMin()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TicketLocation = "a"; //this should be Ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TicketLocationMinPlusOne()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TicketLocation = "aa"; //this should be ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TicketLocationMaxLessOne()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TicketLocation = "";
            TicketLocation = TicketLocation.PadRight(49, 'a');//this should be ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TicketLocationMax()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TicketLocation = "";
            TicketLocation = TicketLocation.PadRight(50, 'a');//this should be ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TicketLocationMaxPlusOne()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TicketLocation = "";
            TicketLocation = TicketLocation.PadRight(51, 'a');//this should fail
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TicketLocationMid()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TicketLocation = "";
            TicketLocation = TicketLocation.PadRight(25, 'a');//this should be ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TicketLocationExtremeMax()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TicketLocation = "";
            TicketLocation = TicketLocation.PadRight(500, 'a');//this should Fail
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockAmountMinLessOne()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string StockAmount = ""; //this should trigger an error
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockAmountMin()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string StockAmount = "a"; //this should be Ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockAmountMinPlusOne()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string StockAmount = "aa"; //this should be ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockAmountMaxLessOne()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string StockAmount = "";
            StockAmount = StockAmount.PadRight(9, 'a');//this should be ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockAmountMax()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string StockAmount = "";
            StockAmount = StockAmount.PadRight(10, 'a');//this should be ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockAmountMaxPlusOne()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string StockAmount = "";
            StockAmount = StockAmount.PadRight(11, 'a');//this should fail
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockAmountMid()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string StockAmount = "";
            StockAmount = StockAmount.PadRight(5, 'a');//this should be ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockAmountExtremeMax()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string StockAmount = "";
            StockAmount = StockAmount.PadRight(500, 'a');//this should Fail
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TicketPriceMinLessOne()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TicketPrice = ""; //this should trigger an error
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TicketPriceMin()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TicketPrice = "a"; //this should be Ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TicketPriceMinPlusOne()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TicketPrice = "aa"; //this should be ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TicketPriceMaxLessOne()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TicketPrice = "";
            TicketPrice = TicketPrice.PadRight(9, 'a');//this should be ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TicketPriceMax()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TicketPrice = "";
            TicketPrice = TicketPrice.PadRight(10, 'a');//this should be ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TicketPriceMaxPlusOne()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TicketPrice = "";
            TicketPrice = TicketPrice.PadRight(11, 'a');//this should fail
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TicketPriceMid()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TicketPrice = "";
            TicketPrice = TicketPrice.PadRight(5, 'a');//this should be ok
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TicketPriceExtremeMax()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TicketPrice = "";
            TicketPrice = TicketPrice.PadRight(500, 'a');//this should Fail
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TimeTicketGoOnSaleExtremeMin()
        {
            //create instance of the class we want to create 
            clsStock Stock = new clsStock();
            // string c= variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string TimeTicketsGoOnSale = TestDate.ToString();
            // invoke this method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TimeTicketsGoOnSaleMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string TimeTicketsGoOnSale = TestDate.ToString();
            //invoke the method
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
      //[TestMethod]
      //public void TimeTicketsGoOnSaleMin()
      //{
            //create an instance of the class we want to create
      //    clsStock Stock = new clsStock();
            //string variable to store any error message
      //    String Error = "";
            //create a variable to store the test date data
      //    DateTime TestDate;
            //set the date totodays date
      //    TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
      //   string TimeTicketsGoOnSale = TestDate.ToString();
            //invoke the method
      //   Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see that the result is correct
      //   Assert.AreNotEqual(Error, "");
      // }
      // [TestMethod]
      //  public void TimeTicketsGoOnSaleMinplusOne()
      //  {
            //create an instance of the class we want to create
      //      clsStock Stock = new clsStock();
            //string variable to store any error message
      //     String Error = "";
            //create a variable to store the test date data
      //     DateTime TestDate;
            //set the date totodays date
      //     TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
      //     TestDate = TestDate.AddDays(+1);
            //convert the date variable to a string variable
      //    string TimeTicketsGoOnSale = TestDate.ToString();
            //invoke the method
      //     Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see that the result is correct
      //     Assert.AreNotEqual(Error, "");

      // }
        [TestMethod]
        public void TimeTicketsGoOnSaleExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string TimeTicketsGoOnSale = TestDate.ToString();
            //invoke the method
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TimeTicketsGoOnSaleInvalidData()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variables to store any error message
            String Error = "";
            //set the Time tickets go on sale to a non date value
            string TimeTicketsGoOnSale = " This is not a date!";
            //invoke the method 
            Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}

