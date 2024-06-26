﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private member data for thiscustomer
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private data
                return mCustomerList.Count;
            }
            set
            {
                //set the private data

            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }


        //constructor for the class
        public clsCustomerCollection()
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_TblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a record to the database based on the valuesof mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerCardNo", mThisCustomer.CustomerCardNo);
            DB.AddParameter("@CustomerCVC", mThisCustomer.CustomerCVC);
            DB.AddParameter("@CustomerExpiryDate", mThisCustomer.CustomerExpiryDate);
            DB.AddParameter("@CustomerJoinDate", mThisCustomer.CustomerJoinDate);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerEmailAddress", mThisCustomer.CustomerEmailAddress);
            DB.AddParameter("@AccountActivity", mThisCustomer.AccountActivity);

            //execute the query returning the primary key value
            return DB.Execute("sproc_TblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerCardNo", mThisCustomer.CustomerCardNo);
            DB.AddParameter("@CustomerCVC", mThisCustomer.CustomerCVC);
            DB.AddParameter("@CustomerExpiryDate", mThisCustomer.CustomerExpiryDate);
            DB.AddParameter("@CustomerJoinDate", mThisCustomer.CustomerJoinDate);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerEmailAddress", mThisCustomer.CustomerEmailAddress);
            DB.AddParameter("@AccountActivity", mThisCustomer.AccountActivity);
            //execute the stored procedure
            DB.Execute("sproc_TblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paarameters for the stored procedure
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_TblCustomer_Delete");
        }

        public void ReportByCustomerAddress(string CustomerAddress)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the CustomerAddress parameter to the database
            DB.AddParameter("@CustomerAddress", CustomerAddress);
            //execute the stored procedure
            DB.Execute("sproc_TblCustomer_FilterByCustomerAddress");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates array based on data table in parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer Customer = new clsCustomer();
                //read in the fields for the current record
                Customer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                Customer.CustomerCardNo = Convert.ToInt64(DB.DataTable.Rows[Index]["CustomerCardNo"]);
                Customer.CustomerCVC = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerCVC"]);
                Customer.CustomerExpiryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerExpiryDate"]);
                Customer.CustomerJoinDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerJoinDate"]);
                Customer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                Customer.CustomerEmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmailAddress"]);
                Customer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                Customer.AccountActivity = Convert.ToBoolean(DB.DataTable.Rows[Index]["AccountActivity"]);
                //add the record to the private data member
                mCustomerList.Add(Customer);
                //point at the record
                Index++;
            }



        }





    }

}
        

    
