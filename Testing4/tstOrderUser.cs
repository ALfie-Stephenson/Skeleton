﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrderUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsOrderUser AnUser = new clsOrderUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]

        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]

        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "Fareed";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]

        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "Newwwwy26";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]

        public void DepartmentPropertyOK()
        {
            //create an istance of the class we want to create 
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "Order";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]

        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create a Boolean variable to store the reults of the validATION
            Boolean Found = false;
            //create some test data to use with the method 
            string UserName = "Fareed";
            string Password = "Newwwwy26";
            //invoke the method 
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create 
            clsOrderUser AnUser = new clsOrderUser();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            string UserName = "Fareed";
            string Password = "Newwwwy26";
            //invoke the method 
            Found = AnUser.FindUser(UserName, Password);
            //check the user id property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }


}
