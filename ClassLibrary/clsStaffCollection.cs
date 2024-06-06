using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {

        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private member data for ThisStaff
        clsStaff mThisStaff = new clsStaff();

        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private data
                return mStaffList.Count;
            }
            set
            {
                //set the private data

            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }


        //constructor for the class
        public clsStaffCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Staff
                clsStaff Staff = new clsStaff();
                //read in the fields for the current record

                Staff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                Staff.StaffPermission = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffPermission"]);
                Staff.StaffOnShift = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffOnShift"]);
                Staff.StaffDataDelete = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffDataDelete"]);
                Staff.StaffStart = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffStart"]);
                Staff.StaffRole = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]);
                Staff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                //add the record to the private data member
                mStaffList.Add(Staff);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the valuesof mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("@StaffDataDelete", mThisStaff.StaffDataDelete);
            DB.AddParameter("@StaffOnShift", mThisStaff.StaffOnShift);
            DB.AddParameter("@StaffStart", mThisStaff.StaffStart);
            DB.AddParameter("@StaffRole", mThisStaff.StaffRole);
            DB.AddParameter("@StaffPermission", mThisStaff.StaffPermission);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }
    }

}