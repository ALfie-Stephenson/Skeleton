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
            Int32 TestData = 1;
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
            Int32 TestData = 55;
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
            if (AnOrder.Price != 450)
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
            if (AnOrder.OrderNo != 5)
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //invoke the method 
            Error = AnOrder.Valid(OrderColour, OrderSummary, DateAddded, Price, OrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}

