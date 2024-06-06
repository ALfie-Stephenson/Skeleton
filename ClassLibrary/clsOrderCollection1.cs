using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices.ComTypes;

namespace ClassLibrary
{
    public class clsOrderCollection1
    {
        //private data member gor the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member for thisOrder
        clsOrder mThisOrder = new clsOrder();

        //public property for the address list
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data 
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsOrderCollection1()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        
        //public property for ThisOrder
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@OrderSummary", mThisOrder.OrderSummary);
            DB.AddParameter("@Stock", mThisOrder.Stock);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@OrderColour", mThisOrder.OrderColour);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");

        }

        public void Update()
        {
            //update an existing record based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@OrderSummary", mThisOrder.OrderSummary);
            DB.AddParameter("@Stock", mThisOrder.Stock);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@OrderColour", mThisOrder.OrderColour);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //deletes the record pointed by thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByOrderNo(string OrderNo)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the OrderNo parameter to the database
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address object
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.Stock = Convert.ToBoolean(DB.DataTable.Rows[Index]["Stock"]);
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.OrderNo = Convert.ToString(DB.DataTable.Rows[Index]["OrderNO"]);
                AnOrder.OrderSummary = Convert.ToString(DB.DataTable.Rows[Index]["OrderSummary"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnOrder.Price = Convert.ToString(DB.DataTable.Rows[Index]["Price"]);
                AnOrder.OrderColour = Convert.ToString(DB.DataTable.Rows[Index]["OrderColour"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }
    }

}