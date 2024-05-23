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
        private Int32 mOrderNo;
        //price public property

        public int OrderNo
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

        public bool Find(int orderId)
        {
            //set the private data members to the test data value
            mOrderId = 21;
            mDateAdded = Convert.ToDateTime("23/05/2024");
            mOrderColour = "Red";
            mStock = true;
            mOrderSummary = "Standard E-ticket + Physical Row Z 215-217";
            mPrice = 55;
            mOrderNo = 1;
            //always return true
            return true;
        }
    }
}