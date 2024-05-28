using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{

    [TestClass]
    public class TstCustomer
    {
        //good test data
        //create some test data to pass the method
        string CustomerName = "Joel Cole";
        string CustomerEmailAddress = "Joelcole@gmail.com";
        string CustomerAddress = "4 JoelColeClose JC4 C1S";
        string CustomerJoinDate = "27/07/2024";
        string CustomerExpiryDate = "27/07/2024";


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

        public void CustomerEmailAddressPropertyOK()
        {
            //create an instance of a class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Stephenbunting180@gmail.com";
            //assign the data to the property
            Customer.CustomerEmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.CustomerEmailAddress, TestData);
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
            if (Customer.AccountActivity != true)
            {
                OK = false;
            }

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
            if (Customer.CustomerJoinDate != Convert.ToDateTime("23/05/2024"))
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
        public void TestCustomerEmailAddressFound()
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
            if (Customer.CustomerEmailAddress != "Theasp@outlook.co.uk")
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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerName = ""; //this should trigger an error
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerName = "j"; //this should be okay
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerName = "jo"; //this should be okay
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerName ="";
            CustomerName = CustomerName.PadRight(49, 'o');//this should be okay
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(50, 'o');//this should be okay
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(25, 'o');//this should be okay
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(51, 'o');//this should trigger an error
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'o');//this should trigger an error
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAdressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerAddress = ""; //this should trigger an error
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAdressMin()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerAddress = "o"; //this should be okay
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAdressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerAddress = "oo"; //this should be okay
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(99, 'o');//this should be okay
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(100, 'o');//this should be okay
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(101, 'o');//this should trigger an error
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(500, 'o');//this should trigger an error
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailAdressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerEmailAddress = ""; //this should trigger an error
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerEmailAdressMin()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerEmailAddress = "o"; //this should be okay
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerEmailAdressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerEmailAddress = "oo"; //this should be okay
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerEmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerEmailAddress = "";
            CustomerEmailAddress = CustomerEmailAddress.PadRight(49, 'o');//this should be okay
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerEmailAddress = "";
            CustomerEmailAddress = CustomerEmailAddress.PadRight(50, 'o');//this should be okay
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerEmailAddress = "";
            CustomerEmailAddress = CustomerEmailAddress.PadRight(25, 'o');//this should be okay
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerEmailAddress = "";
            CustomerEmailAddress = CustomerEmailAddress.PadRight(51, 'o');//this should trigger an error
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerEmailAddress = "";
            CustomerEmailAddress = CustomerEmailAddress.PadRight(500, 'o');//this should trigger an error
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerExpiryDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date was 100 years ago
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string CustomerExpiryDate = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerExpiryDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string CustomerExpiryDate = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerExpiryDateMin()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 1 month in the future
            TestDate = TestDate.AddMonths(1);
            //convert the date variable to a string variable
            string CustomerExpiryDate = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerExpiryDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 2 months in the future
            TestDate = TestDate.AddMonths(2);
            //convert the date variable to a string variable
            string CustomerExpiryDate = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerExpiryDateMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 4 years and 11 months in the future
            TestDate = TestDate.AddYears(4).AddMonths(11);
            //convert the date variable to a string variable
            string CustomerExpiryDate = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerExpiryDateMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 5 years in the future
            TestDate = TestDate.AddYears(5);
            //convert the date variable to a string variable
            string CustomerExpiryDate = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerExpiryDateMid()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 2 and a half years in the future
            TestDate = TestDate.AddYears(2).AddMonths(6);
            //convert the date variable to a string variable
            string CustomerExpiryDate = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerExpiryDateMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 5 years and a month in the future
            TestDate = TestDate.AddYears(5).AddMonths(1);
            //convert the date variable to a string variable
            string CustomerExpiryDate = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerExpiryDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 5 years and a month in the future
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string CustomerExpiryDate = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerExpiryDateInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //set the date added to a non-date value
            string CustomerExpiryDate = "this is not a date!";
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerJoinDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date was 100 years ago
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string CustomerJoinDate = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerJoinDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date was 3 months ago
            TestDate = TestDate.AddMonths(-3);
            //convert the date variable to a string variable
            string CustomerJoinDate = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerJoinDateMin()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string CustomerJoinDate = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerJoinDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 3 months in the future
            TestDate = TestDate.AddMonths(3);
            //convert the date variable to a string variable
            string CustomerJoinDate = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerJoinDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 100 years in the future
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string CustomerJoinDate = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerJoinDateInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //set the CustomerJoinDate to a non date value
            string CustomerJoinDate = "this is not a date!";
            //set the date to todays date
            //invoke the method
            Error = customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
