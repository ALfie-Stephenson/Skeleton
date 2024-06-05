using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace Testing4
{
    [TestClass]
    public class tstorder
    {

        //good test data
        //create some test data to pass the method
        string OrderNo = "5";
        string OrderSummary = "Standard E ticket Row A 1-3";
        string OrderColour = "Red";
        string Price = "450";
        string DateAdded = DateTime.Now.ToShortDateString();

         
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void StockPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Stock = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.Stock, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateAdded = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }

        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "2";
            //assign the data to the property
            AnOrder.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void OrderSummaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "Standard E-ticket + Physical Row Z 215-217";
            //assign the data to the property
            AnOrder.OrderSummary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderSummary, TestData);
        }

        [TestMethod]
        public void OrderColourPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "Red";
            //assign the data to the property
            AnOrder.OrderColour = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderColour, TestData);
        }

        [TestMethod]
        public void PricePropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "450";
            //assign the data to the property
            AnOrder.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Price, TestData);

        }

        [TestMethod]
        public void OrderIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);

        }

        [TestMethod]

        public void FindmethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 OrderId = 8;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to storre the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 8;
            //invoke the method 
            Found = AnOrder.Find(OrderId);
            //chck the order Id
            if (AnOrder.OrderId != 8)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create dome test data to use with the method
            Int32 OrderId = 8;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the dateAdded property
            if (AnOrder.DateAdded != Convert.ToDateTime("2024-05-30"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void OrderColourFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 OrderId = 8;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the twon property
            if (AnOrder.OrderColour != "Red")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void OrderStockFound()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 8;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the Stock property
            if (AnOrder.Stock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void OrderSummaryFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 8;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the summary property
            if (AnOrder.OrderSummary != "Standard E ticket , Row A 1-3")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void PriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 OrderId = 8;
            //invoke the method 
            Found = AnOrder.Find(OrderId);
            //check the price property
            if (AnOrder.Price != "450")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void OrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 OrderId = 8;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the street property
            if (AnOrder.OrderNo != "5")
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method 
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //strin c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void OrderNoMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string OrderNo = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to  see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void HouseNoMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderNoMid()
        {
            //create an instance of the lcass we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "aaaaaaaaaaaaaaaaaaaaaaaaa";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method 
            string OrderNo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void OrderNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string OrderNo = "";
            OrderNo = OrderNo.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 year
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //testnto see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the to todays date
            TestDate = DateTime.Now.Date;   
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DateAddedEstremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date";
            //invoke the method 
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void OrderSummaryMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderSummary = "";
            //invoke the method 
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void OrderSummaryMin()
        {
            //create an instancec of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderSummary = "a";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderSummaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string OrderSummary = "aa";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderSummaryMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string OrderSummary = "";
            OrderSummary = OrderSummary.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderColour, OrderSummary, Price, DateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void OrderSummaryMax()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string OrderSummary = "";
            OrderSummary = OrderSummary.PadRight(50, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderSummaryMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any message 
            String Error = "";
            //this should fail
            string OrderSummary = "";
            OrderSummary = OrderSummary.PadRight(51, 'a');
            //invoke the method 
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void OrderSummaryMid()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to variable to store any error message
            String Error = "";
            //this should pass
            string OrderSummary = "";
            OrderSummary = OrderSummary.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderColourMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderColour = "";
            //invoke the method 
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void OrderColourMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderColour = "a";
            //invoke the method 
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void OrderColourMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderColour = "aa";
            //invoke the method 
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderColourMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to storre any error message
            String Error = "";
            //this should pass 
            string OrderColour = "";
            OrderColour = OrderColour.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderColourMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string vaiable to store any error message
            String Error = "";
            //this should pass 
            string OrderColour = "";
            OrderColour = OrderColour.PadRight(50, 'a');
            //invoke the method 
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderColourMaxPlusOne()
        {
            //create an instnce that we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string OrderColour = "";
            OrderColour = OrderColour.PadRight(51, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void OrderColourMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string OrderColour = "";
            OrderColour = OrderColour.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should fail 
            string Price = "";
            //invoke the method 
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "a";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PriceMinPlusOne()
        {
            //create an instance of the class we to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "aa";
            //Invoke the method 
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Town = "";
            Town = Town.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Price = "";
            Price = Price.PadRight(50, 'a');
            //invoke the method 
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnORder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail 
            string Price = "";
            Price = Price.PadRight(51, 'a');
            //invoke the method
            Error = AnORder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]

        public void PriceMid()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Town = "";
            Town = Town.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
      
    }
}

