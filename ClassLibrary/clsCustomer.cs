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

        //private data member for the customer email address property
        private String mCustomerEmailAddress;
        //CustomerEmailAddress public property
        public String CustomerEmailAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerEmailAddress;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerEmailAddress = value;
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
            DB.Execute("sproc_TblCustomer_FilterByCustomerNo");
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
                mCustomerEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmailAddress"]);
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

        public string Valid(string customerName, string customerAddress, string customerEmailAddress, string customerExpiryDate, string customerJoinDate)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the CustomerName is blank
            if (customerName.Length == 0)
            {
                //record the error
                Error = Error + "The Customer Name may not be blank : ";
            }
            //if the Customer name is greater than 50 characters
            if (customerName.Length > 50) 
            {
                //record the error
                Error = Error + "The Customer Name must be 50 characters or less : ";
            }
            //if the CustomerAddress is blank
            if (customerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Customer Address may not be blank : ";
            }
            //if the CustomerAddress is greater than 100 characters
            if (customerAddress.Length > 100)
            {
                //record the error
                Error = Error + "The Customer Address must be 100 characters or less : ";
            }
            //if the CustomerEmailAddres is blank
            if (customerEmailAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Customer Email Address may not be blank : ";
            }
            //if the CustomerEmailAddress is greater than 50 characters
            if (customerEmailAddress.Length > 50)
            {
                //record the error
                Error = Error + "The Customer Email Address must be 50 characters or less : ";
            }
            //create an instance of DateTime to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;
            //check to see if the date is in the future
            if (DateComp > DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the future : ";
            }

            try
            {
                //copy the customerExpiryDate value to the DateTempvariable
                DateTemp = Convert.ToDateTime(customerExpiryDate);

                if (DateTemp < DateComp) //compare customerExpiryDate with date
                {
                    //record the error
                    Error = Error + "The card cannot be expired : ";
                }
                //check to see if the expiry is today (invalid card)
                if (DateTemp == DateComp) //compare customerExpiryDate with date
                {
                    //record the error
                    Error = Error + "The card cannot be expired : ";
                }
                //check to see if the date is more than 5 years on from todays date
                if (DateTemp > DateTime.Now.Date.AddYears(5))
                {
                    Error = Error + "The card expiry cannot be more than 5 years away : ";
                }
                
            }
            catch
            {
                //record the error
                Error = Error + "the date was not a valid date : ";
            }
            
            try
            {
                //copy the customerExpiryDate value to the DateTempvariable
                DateTemp = Convert.ToDateTime(customerJoinDate);

                if (DateTemp < DateComp) //compare customerExpiryDate with date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past: ";
                }
                //check to see if the date is in the future
                if (DateTemp > DateTime.Now.Date.AddMonths(2))
                {
                    Error = Error + "The date cannot be in the future : ";
                }


            }
            catch
            {
                //record the error
                Error = Error + "the date was not a valid date : ";
            }

            //return any error messages
            return Error;
        }

        









    }
}
