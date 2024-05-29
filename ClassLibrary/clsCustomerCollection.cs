﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

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
        public clsCustomer ThisCustomer { get; set; }


        //constructor for the class
        public clsCustomerCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_TblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
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
                //point at the next record
                Index++;
            }
        }

    }
}

        

    