using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{

    [TestClass]
    public class TstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class we want to create
            clsCustomer Customer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(Customer);
        }

        [TestMethod]
        public void AccountActivityPropertyOK()
        {
            //create an instance of a class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            Customer.AccountActivity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.AccountActivity, TestData);
        }

        [TestMethod]

        public void CustomerJoinDatePropertyOK()
        {
            //create an instance of a class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Customer.CustomerJoinDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.CustomerJoinDate, TestData);
        }

        [TestMethod]

        public void CustomerExpiryDatePropertyOK()
        {
            //create an instance of a class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Customer.CustomerExpiryDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.CustomerExpiryDate, TestData);
        }

        [TestMethod]

        public void CustomerAddressPropertyOK()
        {
            //create an instance of a class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "83 Collingham Rd LE3 2BB";
            //assign the data to the property
            Customer.CustomerAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.CustomerAddress, TestData);
        }

        [TestMethod]

        public void CustomerNoPropertyOK()
        {
            //create an instance of a class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Customer.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.CustomerNo, TestData);
        }

        [TestMethod]

        public void CustomerCardNoPropertyOK()
        {
            //create an instance of a class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            Int64 TestData = 1234567812345678;
            //assign the data to the property
            Customer.CustomerCardNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.CustomerCardNo, TestData);
        }

        [TestMethod]

        public void CustomerCVCPropertyOK()
        {
            //create an instance of a class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 123;
            //assign the data to the property
            Customer.CustomerCVC = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.CustomerCVC, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerNo = 4;
            //invoke the method
            Found = Customer.Find(CustomerNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 6;
            //invoke the method
            Found = Customer.Find(CustomerNo);
            //check the address id
            if (Customer.CustomerNo != 6)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerCardNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 6;
            //invoke the method
            Found = Customer.Find(CustomerNo);
            //check the address id
            if (Customer.CustomerCardNo != 8456219854761270)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerCVCFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 6;
            //invoke the method
            Found = Customer.Find(CustomerNo);
            //check the address id
            if (Customer.CustomerCVC != 196)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAccountActivityFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 6;
            //invoke the method
            Found = Customer.Find(CustomerNo);
            //check the address id
            if (Customer.AccountActivity != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerJoinDateFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 6;
            //invoke the method
            Found = Customer.Find(CustomerNo);
            //check the address id
            if (Customer.CustomerJoinDate != DateTime.Now.Date)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerExpiryDateFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 6;
            //invoke the method
            Found = Customer.Find(CustomerNo);
            //check the address id
            if (Customer.CustomerExpiryDate != Convert.ToDateTime("01/04/2028"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 6;
            //invoke the method
            Found = Customer.Find(CustomerNo);
            //check the address id
            if (Customer.CustomerAddress != "34 The Asp Way MN7 6GD")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 6;
            //invoke the method
            Found = Customer.Find(CustomerNo);
            //check the address id
            if (Customer.CustomerName != "Nathan Aspinall")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
