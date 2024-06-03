using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the address id property
        private Int32 mOrderId;

        //orderId public property
        public Int32 OrderId
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code sends data out of the property
                mOrderId = value;
            }
        }

        //private data member for the date added property
        private DateTime mDateAdded;
        //dateAdded public property

        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }

        //private data member for the Colour Property
        private string mOrderColour;
        //Colour public property
        public string OrderColour
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderColour;
            }
            set
            {
                //this line of code allows data into the property
                mOrderColour = value;
            }
        }

        //private data member for the Stock Property
        private Boolean mStock;
        //stock public property
        public bool Stock
        {
            get
            {
                //this line of code sends data out of the property
                return mStock;
            }
            set
            {
                //this line of code allows data into the property 
                mStock = value;
            }
        }

        //private data member for the order summary property
        private String mOrderSummary;
        //OrderSummary public property
        public string OrderSummary
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderSummary;
            }
            set
            {
                //this line of code sends data out of the property
                mOrderSummary = value;
            }
        }

        //private data member for the price property
        private Int32 mPrice;
        //price public property
        public int Price
        {
            get
            {
                //this line of code sends data out of the property
                return mPrice;
            }
            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }
        }

        //private data member for the OrderNo property
        private String mOrderNo;
        //price public property

        public String OrderNo
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderNo;
            }
            set
            {
                //this line of code allows data into the property
                mOrderNo = value;
            }
        }

        public bool Active { get; set; }
        //public DateTime DateAdded { get; set; }
        //public int OrderNo { get; set; }
        //public string OrderSummary { get; set; }
        //public string OrderColour { get; set; }
        //public int Price { get; set; }
        //public bool Stock { get; set; }
        //public int OrderId { get; set; }

        public bool Find(int OrderId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection(); 
            //add the parameter for the address id to search for 
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterOrderId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mOrderColour = Convert.ToString(DB.DataTable.Rows[0]["OrderColour"]);
                mStock = Convert.ToBoolean(DB.DataTable.Rows[0]["Stock"]);
                mOrderSummary = Convert.ToString(DB.DataTable.Rows[0]["OrderSummary"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mOrderNo = Convert.ToString(DB.DataTable.Rows[0]["OrderNo"]);
                //return that everyhting worked OK
                return true;

            }
            //if no record was found 
            else
            {
                //return false indicating there was a problem
                return false;   
            }
        }

        public string Valid(string OrderColour, string OrderSummary, object DateAdded, string Price, string OrderNo)
        {
            //create a string variable to store the erro
            String Error = "";
            //if the OrderNo is blank
            if (OrderNo.Length == 0)
            {
                //record the error 
                Error = Error + "The Order number may not be blank : ";

            }
            //return any error messages
            return Error;
        }
    }
}