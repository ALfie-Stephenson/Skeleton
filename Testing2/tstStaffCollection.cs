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
            TestItem.StaffName = "Liibaan";
            TestItem.StaffRole = "Staff Handler";
            TestItem.StaffStart = DateTime.Now;
            TestItem.StaffDataDelete = false;
            TestItem.StaffOnShift = true;
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
            TestItem.StaffNo = 1;
            TestItem.StaffName = "Liibaan";
            TestItem.StaffRole = "Staff Handler";
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

        [TestMethod]

        public void UpdateMethodOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffPermission = true;
            TestItem.StaffNo = 1;
            TestItem.StaffName = "Liibaan";
            TestItem.StaffRole = "Staff Handler";
            TestItem.StaffStart = DateTime.Now;
            TestItem.StaffDataDelete = false;
            TestItem.StaffOnShift = true;
            //set thisstaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
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
            AllStaffs.Update();
            //Find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //Test to see the two value are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }

        [TestMethod]

        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffPermission = true;
            TestItem.StaffNo = 1;
            TestItem.StaffName = "Liibaan";
            TestItem.StaffRole = "Staff Handler";
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
            //delete the record
            AllStaffs.Delete();
            //now find the record 
            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }
        [TestMethod]

        public void ReportByStaffRoleMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create an instance of the filtered data   
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //return all records;
            FilteredStaffs.ReportByStaffRole("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.Count, FilteredStaffs.Count);
        }
        [TestMethod]

        public void ReportByStaffRoleNoneFound()
        {
            //create an instance of the class we want to create
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a role that doesnt exist
            FilteredStaffs.ReportByStaffRole("xxxxx xxxxxxx");
            //test to see that there are no records 
            Assert.AreEqual(0, FilteredStaffs.Count);
        }
        [TestMethod]

        public void ReportByStaffRoleTestDataFound()
        {
            //create an instance of the class we want to create
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a role that doesnt exist
            FilteredStaffs.ReportByStaffRole("Staff Hanlder");
            //check that the correct number of records are found
            if (FilteredStaffs.Count == 2)
            {
                //check to see that the first record is 1
                if (FilteredStaffs.StaffList[0].StaffNo != 1)
                {
                    OK = false;
                }
                //check to see that the first record is 2
                if (FilteredStaffs.StaffList[1].StaffNo != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
    }
}