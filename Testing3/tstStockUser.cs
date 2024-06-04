using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStockUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStockUser AnUser = new clsStockUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]

        public void UserIDPropertyOk()
        {
            //create an instance of the class we want to make 
            clsStockUser AnUser = new clsStockUser();
            //create some test data to asign to the property
            Int32 TestData = 1;
            //assign the data to the property 
            AnUser.UserID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]

        public void UserNamePropertyOk()
        {
            //create an instance of the class we want to make 
            clsStockUser AnUser = new clsStockUser();
            //create some test data to asign to the property
            string TestData = "Alfie";
            //assign the data to the property 
            AnUser.UserName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]

        public void PasswordPropertyOk()
        {
            //create an instance of the class we want to make 
            clsStockUser AnUser = new clsStockUser();
            //create some test data to asign to the property
            string TestData = "LeBOSH123";
            //assign the data to the property 
            AnUser.Password = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]

        public void DepartmentPropertyOk()
        {
            //create an instance of the class we want to make 
            clsStockUser AnUser = new clsStockUser();
            //create some test data to asign to the property
            string TestData = "Stock";
            //assign the data to the property 
            AnUser.Department = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            string UserName = "Alfie";
            string Password = "LeBOSH123";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUsernameStockFound()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record is the data is ok 
            Boolean OK = true;
            //create some test data to use with the method 
            string UserName = "Alfie";
            string Password = "LeBOSH123";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //check the user id property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                 OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
    }
}
