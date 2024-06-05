using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);

        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data need to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.AccountActivity = true;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "Joel Cole";
            TestItem.CustomerEmailAddress = "Joelcole@gmail.com";
            TestItem.CustomerAddress = "4 JoelColeClose JC4 C1S";
            TestItem.CustomerJoinDate = Convert.ToDateTime("27/07/2024");
            TestItem.CustomerExpiryDate = Convert.ToDateTime("27/07/2024");
            TestItem.CustomerCVC = 333;
            TestItem.CustomerCardNo = 3333444455556666;
            //add the item to te test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        

        [TestMethod]
        public void ThisCustomerProppertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.AccountActivity = true;
            TestCustomer.CustomerNo = 1;
            TestCustomer.CustomerName = "Joel Cole";
            TestCustomer.CustomerEmailAddress = "Joelcole@gmail.com";
            TestCustomer.CustomerAddress = "4 JoelColeClose JC4 C1S";
            TestCustomer.CustomerJoinDate = Convert.ToDateTime("27/07/2024");
            TestCustomer.CustomerExpiryDate = Convert.ToDateTime("27/07/2024");
            TestCustomer.CustomerCVC = 333;
            TestCustomer.CustomerCardNo = 3333444455556666;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.AccountActivity = true;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "Joel Cole";
            TestItem.CustomerEmailAddress = "Joelcole@gmail.com";
            TestItem.CustomerAddress = "4 JoelColeClose JC4 C1S";
            TestItem.CustomerJoinDate = Convert.ToDateTime("27/07/2024");
            TestItem.CustomerExpiryDate = Convert.ToDateTime("27/07/2024");
            TestItem.CustomerCVC = 333;
            TestItem.CustomerCardNo = 3333444455556666;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the twovalues are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AccountActivity = true;
            TestItem.CustomerNo = 7;
            TestItem.CustomerName = "Phil Taylor";
            TestItem.CustomerEmailAddress = "ThePower@outlook.co.uk";
            TestItem.CustomerAddress = "69 Harvard Close FG5 67H";
            TestItem.CustomerJoinDate = Convert.ToDateTime("28/05/2024");
            TestItem.CustomerExpiryDate = Convert.ToDateTime("01/07/2027");
            TestItem.CustomerCVC = 236;
            TestItem.CustomerCardNo = 7592345196471908;
            //set thiscustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);


        }

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AccountActivity = true;
            TestItem.CustomerName = "Phil Taylor";
            TestItem.CustomerEmailAddress = "ThePower@outlook.co.uk";
            TestItem.CustomerAddress = "69 Harvard Close FG5 67H";
            TestItem.CustomerJoinDate = Convert.ToDateTime("28/05/2024");
            TestItem.CustomerExpiryDate = Convert.ToDateTime("01/07/2027");
            TestItem.CustomerCVC = 236;
            TestItem.CustomerCardNo = 7592345196471908;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the data
            TestItem.CustomerNo = PrimaryKey;
            //modidy the test record
            TestItem.AccountActivity = false;
            TestItem.CustomerName = "Luke Littler";
            TestItem.CustomerEmailAddress = "TheNuke@gmail.com";
            TestItem.CustomerAddress = "49 Harvard Close FG5 67H";
            TestItem.CustomerJoinDate = Convert.ToDateTime("29/05/2024");
            TestItem.CustomerExpiryDate = Convert.ToDateTime("01/05/2027");
            TestItem.CustomerCVC = 237;
            TestItem.CustomerCardNo = 7592995196471908;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AccountActivity = true;
            TestItem.CustomerName = "Phil Taylor";
            TestItem.CustomerEmailAddress = "ThePower@outlook.co.uk";
            TestItem.CustomerAddress = "69 Harvard Close FG5 67H";
            TestItem.CustomerJoinDate = Convert.ToDateTime("28/05/2024");
            TestItem.CustomerExpiryDate = Convert.ToDateTime("01/07/2027");
            TestItem.CustomerCVC = 236;
            TestItem.CustomerCardNo = 7592345196471908;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsTrue(Found);
        }

    }

}
