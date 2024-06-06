using System;
using System.Collections.Generic;
using System.Data.Common;

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
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsOrder AnOrder = new clsOrder();
                //reaf in the fields for the current record
                AnOrder.Stock = Convert.ToBoolean(DB.DataTable.Rows[Index]["Stock"]);
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.OrderSummary = Convert.ToString(DB.DataTable.Rows[Index]["OrderSummary"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnOrder.OrderColour = Convert.ToString(DB.DataTable.Rows[Index]["OrderColour"]);
                AnOrder.Price = Convert.ToString(DB.DataTable.Rows[Index]["Price"]);
                AnOrder.OrderNo = Convert.ToString(DB.DataTable.Rows[Index]["OrderNo"]);
                //add the ecord to the private data member
                mOrderList.Add( AnOrder );
                //point at the next record
                Index++;
            }
            //create the items of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Stock = true;
            TestItem.OrderId = 1;
            TestItem.OrderSummary = "Standard E ticket Row A 1-3";
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderNo = "5";
            TestItem.Price = "450";
            TestItem.OrderColour = "Red";
            //add the test item to the item list
            mOrderList.Add(TestItem);
            //re intialise the object for some new data
            TestItem = new clsOrder();
            //set its properties
            TestItem.Stock = true;
            TestItem.OrderId = 1;
            TestItem.OrderSummary = "Standard E ticket Row A 1-3";
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderNo = "5";
            TestItem.Price = "450";
            TestItem.OrderColour = "Red";
            //add the item to the test list
            mOrderList.Add(TestItem);
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
            DB.AddParameter("Stock", mThisOrder.Stock);
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
    }

}