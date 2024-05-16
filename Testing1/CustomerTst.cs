﻿using ClassLibrary;
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
    }
}