using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private member data for thisstock
        clsStock mThisStock = new clsStock();

        //public property for the address list
        public List<clsStock> StockList
        {
            get
            {
                //SET THE PRIVATE DATA
                return mStockList;
            }
            set
            {
                //set the private data 
                mStockList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return StockList.Count;
            }

            set
            {
                //we shall worry about this later
            }
        }
        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;

            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }
        
        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the record of count
            RecordCount = DB.Count;
            // while there are records to process
            while (Index <RecordCount)
            {
                //create a blank address 
                clsStock Stock = new clsStock();
                //read in the fields for the current record
                Stock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                Stock.GameID = Convert.ToString(DB.DataTable.Rows[Index]["GameID"]);
                Stock.TicketLocation = Convert.ToString(DB.DataTable.Rows[Index]["TicketLocation"]);
                Stock.StockAmount = Convert.ToInt32(DB.DataTable.Rows[Index]["StockAmount"]);
                Stock.TicketPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["TicketPrice"]);
                Stock.TimeTicketsGoOnSale = Convert.ToDateTime(DB.DataTable.Rows[Index]["TimeTicketsGoOnSale"]);
                Stock.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                //add the record to the private data member
                mStockList.Add(Stock);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisStock
            //set the primary key value of the new record 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@GameID", mThisStock.GameID);
            DB.AddParameter("@TicketLocation", mThisStock.TicketLocation);
            DB.AddParameter("@StockAmount", mThisStock.StockAmount);
            DB.AddParameter("@TicketPrice", mThisStock.TicketPrice);
            DB.AddParameter("@TimeTicketsGoOnSale", mThisStock.TimeTicketsGoOnSale);
            DB.AddParameter("@InStock", mThisStock.InStock);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }
    }
}