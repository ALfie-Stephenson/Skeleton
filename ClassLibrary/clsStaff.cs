using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the Staff number property
        private Int32 mStaffNo;

        //StaffNo public property
        public int StaffNo
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffNo;
            }
            set
            {
                //this line of code allows data into the property
                mStaffNo = value;
            }
        }


        //private data member for the Staff name property
        private String mStaffName;

        //StaffName public property
        public String StaffName
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffName;
            }
            set
            {
                //this line of code allows data into the property
                mStaffName = value;
            }
        }


        //private data member for the Staff Role property
        private String mStaffRole;

        //StaffRole public property
        public String StaffRole
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffRole;
            }
            set
            {
                //this line of code allows data into the property
                mStaffRole = value;
            }
        }

        //private data member for the Staff join date property
        private DateTime mStaffStart;

        //StaffStart public property
        public DateTime StaffStart
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffStart;
            }
            set
            {
                //this line of code allows data into the property
                mStaffStart = value;
            }
        }


        //private data member for the Staff Permission property
        private Boolean mStaffPermission;

        //StaffPermission public property
        public bool StaffPermission
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffPermission;
            }
            set
            {
                //this line of code allows data into the property
                mStaffPermission = value;
            }
        }


        //private data member for the Staff On Shift property
        private Boolean mStaffOnShift;

        //StaffPermission public property
        public bool StaffOnShift
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffOnShift;
            }
            set
            {
                //this line of code allows data into the property
                mStaffOnShift = value;
            }
        }


        //private data member for the Staff Data Delete property
        private Boolean mStaffDataDelete;

        //StaffPermission public property
        public bool StaffDataDelete
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffDataDelete;
            }
            set
            {
                //this line of code allows data into the property
                mStaffDataDelete = value;
            }
        }

        public bool Active { get; set; }

        public bool Find(int StaffNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@StaffNo", StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterStaffNo");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {


                //copy the data from the database to the private data members
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mStaffPermission = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffPermission"]);
                mStaffOnShift = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffOnShift"]);
                mStaffDataDelete = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffDataDelete"]);
                mStaffStart = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffStart"]);
                mStaffRole = Convert.ToString(DB.DataTable.Rows[0]["StaffRole"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
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


        public string Valid(string staffName, string staffRole, string staffStart, string staffNo)

        {
            return "";
        }
    }
}
        
