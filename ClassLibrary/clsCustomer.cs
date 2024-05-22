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





        /******* FIND METHOD ********/
        public bool Find(int CustomerNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {

                //copy the data from the database to the private data members
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mCustomerCardNo = Convert.ToInt64(DB.DataTable.Rows[0]["CustomerCardNo"]); 
                mCustomerCVC = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerCVC"]); 
                mAccountActivity = Convert.ToBoolean(DB.DataTable.Rows[0]["AccountActivity"]); 
                mCustomerJoinDate = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerJoinDate"]); 
                mCustomerExpiryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerExpiryDate"]); 
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]); 
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]); 
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating theres a problem
                return false;
            }
        }
    }
}
