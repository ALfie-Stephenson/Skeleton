using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Testing2
{

    [TestClass]
    public class TstStaff
    {
        //good test data
        //create some test data to pass the method
        string StaffNo = "1";
        string StaffName = "Liibaan";
        string StaffRole = "Staff Handler";
        string StaffStart = DateTime.Now.ToShortDateString();



        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class we want to create
            clsStaff Staff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(Staff);
        }


        [TestMethod]

        public void StaffNoPropertyOK()
        {
            //create an instance of a class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Staff.StaffNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.StaffNo, TestData);
        }

        [TestMethod]

        public void StaffNamePropertyOK()
        {
            //create an instance of a class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Liibaan";
            //assign the data to the property
            Staff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.StaffName, TestData);

        }

        [TestMethod]

        public void StaffRolePropertyOK()
        {
            //create an instance of a class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Staff Handler";
            //assign the data to the property
            Staff.StaffRole = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.StaffRole, TestData);

        }

        [TestMethod]
        public void StaffStartPropertyOK()
        {
            //create an instance of a class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Staff.StaffStart = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.StaffStart, TestData);
        }

        [TestMethod]
        public void StaffPermissionPropertyOK()
        {
            //create an instance of a class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            Staff.StaffPermission = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.StaffPermission, TestData);
        }

        [TestMethod]
        public void StaffOnShiftPropertyOK()
        {
            //create an instance of a class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            Staff.StaffOnShift = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.StaffOnShift, TestData);
        }

        [TestMethod]
        public void StaffDataDeletePropertyOK()
        {
            //create an instance of a class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = false;
            //assign the data to the property
            Staff.StaffDataDelete = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.StaffDataDelete, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = Staff.Find(StaffNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = Staff.Find(StaffNo);
            //check the address id
            if (Staff.StaffNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPermissionFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = Staff.Find(StaffNo);
            //check the address id
            if (Staff.StaffPermission != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffOnShiftFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = Staff.Find(StaffNo);
            //check the address id
            if (Staff.StaffOnShift != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffDataDeleteFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = Staff.Find(StaffNo);
            //check the address id
            if (Staff.StaffDataDelete != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffStartFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = Staff.Find(StaffNo);
            //check the Staff id
            if (Staff.StaffStart != DateTime.Now.Date)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffRoleFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = Staff.Find(StaffNo);
            //check the address id
            if (Staff.StaffRole != "Staff Handler")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = Staff.Find(StaffNo);
            //check the address id
            if (Staff.StaffName != "Liibaan")
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
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //invoke the method 
            Error = Staff.Valid(StaffNo, StaffName, StaffStart, StaffRole);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}


 