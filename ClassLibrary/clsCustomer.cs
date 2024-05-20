using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customer number property
        private Int32 mCustomerNo;

        //CustomerNo public property
        public int CustomerNo
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerNo;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerNo = value;
            }
        }
        //private data member for the customer card number property
        private Int64 mCustomerCardNo;

        //CustomerCardNo public property
        public Int64 CustomerCardNo
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerCardNo;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerCardNo = value;
            }
        }
        //private data member for the customer CVC property
        private Int32 mCustomerCVC;

        //CustomerCVC public property
        public int CustomerCVC
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerCVC;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerCVC = value;
            }
        }
        //private data member for the customer name property
        private String mCustomerName;

        //CustomerName public property
        public String CustomerName
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerName;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerName = value;
            }
        }
        //private data member for the customer address property
        private String mCustomerAddress;

        //CustomerAddress public property
        public String CustomerAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerAddress;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerAddress = value;
            }
        }
        //private data member for the account activity property
        private Boolean mAccountActivity;

        //AccountActivity public property
        public bool AccountActivity
        {
            get
            {
                //this line of code sends data out of the property
                return mAccountActivity;
            }
            set
            {
                //this line of code allows data into the property
                mAccountActivity = value;
            }
        }
        //private data member for the customer join date property
        private DateTime mCustomerJoinDate;

        //CustomerJoinDate public property
        public DateTime CustomerJoinDate
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerJoinDate;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerJoinDate = value;
            }
        }
        //private data member for the customer expiry date property
        private DateTime mCustomerExpiryDate;

        //CustomerExpiryDate public property
        public DateTime CustomerExpiryDate
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerExpiryDate;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerExpiryDate = value;
            }
        }



        //public bool AccountActivity { get; set; }
        //public DateTime CustomerJoinDate { get; set; }
        //public DateTime CustomerExpiryDate { get; set; }
        //public string CustomerAddress { get; set; }
        //public string CustomerName { get; set; }
        //public int CustomerNo { get; set; }
        //public long CustomerCardNo { get; set; }
        //public int CustomerCVC { get; set; }






        public bool Find(int CustomerNo)
        {
            //set the private data members to the test data value
            mCustomerNo = 21;
            mCustomerCardNo = 9999999999999999;
            mCustomerCVC = 212;
            mAccountActivity = true;
            mCustomerJoinDate = DateTime.Now.Date;
            mCustomerExpiryDate = Convert.ToDateTime("01/06/2027");
            mCustomerAddress = "43 egg street";
            mCustomerName = "Stephen Bunting";
            //always return true
            return true;
        }
    }
}
