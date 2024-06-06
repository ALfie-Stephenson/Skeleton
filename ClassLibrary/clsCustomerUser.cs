using System;

namespace ClassLibrary
{
    public class clsCustomerUser
    {
        //private data member for the userid property
        private Int32 mUserID;
        //private data member for the password property
        private string mPassword;
        //private data member for the username property
        private string mUserName;
        //private data member for the department property
        private string mDepartment;
        public int UserID
        {
            get
            {
                //return the priate data
                return mUserID;
            }
            set
            {
                //set the private data
                mUserID = value;
            }
        }
        public string Password
        {
            get
            {
                //return the priate data
                return mPassword;
            }
            set
            {
                //set the private data
                mPassword = value;
            }
        }
        public string UserName
        {
            get
            {
                //return the priate data
                return mUserName;
            }
            set
            {
                //set the private data
                mUserName = value;
            }
        }
        public string Department
        {
            get
            {
                //return the priate data
                return mDepartment;
            }
            set
            {
                //set the private data
                mDepartment = value;
            }
        }

        public bool FindUser(string UserName, string Password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the username and password to search for
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            //execute the procedure
            DB.Execute("sproc_tblUsers_FindUserNamePWCustomer");
            //if one record is found (there should either be one or none)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything worked ok
                return true;
            }
            else
            { 
                return false;
            }
            
        }
    }
}