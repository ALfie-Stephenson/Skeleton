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
            Error = Staff.Valid(StaffName, StaffStart, StaffRole);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = ""; 
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffNameMin()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = "l";  
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = "li";  
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = "";
            StaffName = StaffName.PadRight(49, 'i'); 
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = "";
            StaffName = StaffName.PadRight(50, 'i'); 
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = "";
            StaffName = StaffName.PadRight(25, 'i'); 
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = "";
            StaffName = StaffName.PadRight(51, 'i'); 
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = "";
            StaffName = StaffName.PadRight(500, 'i'); 
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffRole = "";  
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffRoleMin()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffRole = "h";  
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffRoleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffRole = "ha";  
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffRoleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(99, 'i'); 
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMax()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(100, 'i'); 
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(101, 'i'); 
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(500, 'i'); 
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date was 50 years ago
            TestDate = TestDate.AddYears(-50);
            //convert the date variable to a string variable
            string StaffStart = TestDate.ToString();
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date was 1 months ago
            TestDate = TestDate.AddMonths(-1);
            //convert the date variable to a string variable
            string StaffStart = TestDate.ToString();
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartMin()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string StaffStart = TestDate.ToString();
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date was 1 month ago
            TestDate = TestDate.AddMonths(-1);
            //convert the date variable to a string variable
            string StaffStart = TestDate.ToString();
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date a year ago
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            string StaffStart = TestDate.ToString();
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the StaffStart to a incorrect date value
            string StaffStart = "Incorrect date input!";
            //set to todays date
            //invoke the method
            Error = staff.Valid(StaffName, StaffRole, StaffStart);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}


 