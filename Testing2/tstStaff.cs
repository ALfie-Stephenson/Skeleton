using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{

    [TestClass]
    public class TstStaff
        {
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
                Int32 TestData = 123;
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
                Boolean TestData = false;
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
        }
}