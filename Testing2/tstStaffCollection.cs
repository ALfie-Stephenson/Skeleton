using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;


namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaffs);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list 
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffPermission = true;
            TestItem.StaffNo = 1;
            TestItem.StaffName = "Liibaan";
            TestItem.StaffStart = DateTime.Now;
            TestItem.StaffDataDelete = false;
            TestItem.StaffRole = "Staff Handler";
            TestItem.StaffOnShift = true;
            //add the time to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.StaffList, TestList);
        }


        [TestMethod]
        public void ThisStaffProppertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.StaffPermission = true;
            TestStaff.StaffNo = 1;
            TestStaff.StaffName = "Liibaan";
            TestStaff.StaffRole = "Staff Handler";
            TestStaff.StaffStart = DateTime.Now;
            TestStaff.StaffDataDelete = false;
            TestStaff.StaffOnShift = true;
            //assign the data to the property
            AllStaffs.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an Item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffPermission = true;
            TestItem.StaffNo = 1;
            TestItem.StaffName = "Joe";
            TestItem.StaffRole = "Customer Handler";
            TestItem.StaffStart = DateTime.Now;
            TestItem.StaffDataDelete = false;
            TestItem.StaffOnShift = false;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffPermission = true;
            TestItem.StaffNo = 3;
            TestItem.StaffName = "Alfie";
            TestItem.StaffRole = "Stock Handler";
            TestItem.StaffStart = DateTime.Now;
            TestItem.StaffDataDelete = false;
            TestItem.StaffOnShift = true;
            //set thisstaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }
    }
}