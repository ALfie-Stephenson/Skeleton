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

        public string Valid(string orderNo, string orderSummary, string orderColour, string price, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the OrderNo is blank
            if (orderNo.Length == 0)
            {
                //record the error
                Error = Error + "The house number may not be blank : ";
            }
            //if the order no is greater than 6 characters
            if (orderNo.Length > 50)
            {
                //record the error 
                Error = Error + "The house no must be less than 6 characters : ";
            }
            //create an instance of DateTime to compare with DateTemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);

                if (DateTemp < DateComp) //compare dateAdded with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error

                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //is the Order summary blank
            if (orderSummary.Length == 0)
            {
                //record the error
                Error = Error + "The Order Summary should not be left blank : ";
                
            }

            //if the Order summary is too long
            if (orderSummary.Length > 50)
            {
                //record the error
                Error = Error + "The OrderSummary must be less than 50 characters : ";
            }

            //if the order colour is blank
            if (orderColour.Length == 0)
            {
                //record the error
                Error = Error + "The Order Colour may not be blank : ";
            }

            //if the the Order colour is too long
            if (orderColour.Length > 50)
            {
                //record the error
                Error = Error + "The Order Colour should be less than 50 characters : ";
            }

            // if Price is blank
            if (price.Length == 0)
            {
                //record the error
                Error = Error + "The price may not be blank : ";
            }

            //if the Price is too long
            if(price.Length > 50)
            {
                //record the error
                Error = Error + "The price must be less than 50 characters : ";
            }
           
            //return any error messages
            return Error;
        }
    }
}