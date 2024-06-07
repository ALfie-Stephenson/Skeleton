using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnOK_Click1(object sender, EventArgs e)
    {

        // create a new instance of clsStaff
        clsStaff Staff = new clsStaff();
        // grab the Staff No
        Staff.StaffNo = Convert.ToInt32(txtStaffNo.Text);
        // grab the Staff's name
        string StaffName = txtStaffName.Text;
        // grab the staffs role
        string StaffRole = txtStaffRole.Text;
        //grab the staff's start date
        string StaffStart = (txtStaffStart.Text);
        // grab the Staff's permission
        Staff.StaffPermission = chkPermission.Checked;
        //grab the staff's on shift data
        Staff.StaffOnShift = chkShift.Checked;
        // grab staff data deletion
        Staff.StaffDataDelete = chkDataDelete.Checked;
        //variable to store any error message
        string Error = "";
        //validate the data
        Error = Staff.Valid(StaffName, StaffRole, StaffStart);
        if (Error == "")
        {
            // grab the Staff No
            Staff.StaffNo = Convert.ToInt32(txtStaffNo.Text);
            // grab the Staff's name
            Staff.StaffName = txtStaffName.Text;
            // grab the staffs role
            Staff.StaffRole = txtStaffRole.Text;
            //grab the staff's start date
            Staff.StaffStart = Convert.ToDateTime(DateTime.Now);
            // grab the Staff's permission
            Staff.StaffPermission = chkPermission.Checked;
            //grab the staff's on shift data
            Staff.StaffOnShift = chkShift.Checked;
            // grab staff data deletion
            Staff.StaffDataDelete = chkDataDelete.Checked;
            //store the Staff in the session object
            Session["Staff"] = Staff;
            //navigate to the view page
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff class
        clsStaff Staff = new clsStaff();
        //create a variable to store the primary key
        Int32 StaffNo;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffNo = Convert.ToInt32(txtStaffNo.Text);
        //find the record
        Found = Staff.Find(StaffNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffNo.Text = Staff.StaffNo.ToString();
            txtStaffName.Text = Staff.StaffName;
            txtStaffRole.Text = Staff.StaffRole;
            txtStaffStart.Text = Staff.StaffStart.ToString();
            chkPermission.Checked = Staff.StaffPermission;
            chkShift.Checked = Staff.StaffOnShift;
            chkDataDelete.Checked = Staff.StaffDataDelete;
            
        }
    }

    void DisplayStaff()
    {
        //create an instance of the Staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update
        StaffBook.ThisStaff.Find(StaffNo);
        //display the data for the record
        txtStaffNo.Text = StaffBook.ThisStaff.StaffNo.ToString();
        chkDataDelete.Checked = StaffBook.ThisStaff.StaffDataDelete;
        txtStaffStart.Text = StaffBook.ThisStaff.StaffStart.ToString();
        chkPermission.Text = StaffBook.ThisStaff.StaffPermission.ToString();
        txtStaffRole.Text = StaffBook.ThisStaff.StaffRole.ToString();
        txtStaffName.Text = StaffBook.ThisStaff.StaffName.ToString();
        chkShift.Text = StaffBook.ThisStaff.StaffOnShift.ToString();

    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

}
