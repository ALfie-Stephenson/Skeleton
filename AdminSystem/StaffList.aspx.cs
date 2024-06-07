using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the Staff number to be processed
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffNo != -1)
            {
                //display the current data for the record
                DisplayStaffs();
            }

        }
        //create a new instance of clsStaffUser
        clsStaffUser AnUser = new clsStaffUser();
        //get data from the session object
        AnUser = (clsStaffUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);
    }

    void DisplayStaffs()
    {
        //create an instance of the staffcollection
        clsStaffCollection Staffs = new clsStaffCollection();
        //set the data source to list of addresses in the collection
        lstStaffList.DataSource = Staffs.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffNo";
        //set the datafield to display
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 StaffNo;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            StaffNo = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffNo"] = StaffNo;
            //redirect to delete page
            Response.Redirect("StaffDelete.aspx");

        }
        else 
        {
            //display an error message
            lblError.Text = "Please select a staff's record from the list to erase";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the staffobject
        clsStaffCollection Staff = new clsStaffCollection();
        //retrieve the value of the address from the presentation layer
        Staff.ReportByStaffRole(txtAddressFilter.Text);
        //set the data source to the list of Staffs in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffNo";
        //set the name of the field to display
        lstStaffList.DataTextField = "StaffRole";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the staffobject
        clsStaffCollection Staff = new clsStaffCollection();
        //set an aempty string
        Staff.ReportByStaffRole("");
        //clear any existing filter to tidy up the interface
        txtAddressFilter.Text = "";
        //set the data source to the list of Staffs in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffNo";
        //set the name of the field to display
        lstStaffList.DataTextField = "StaffRole";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StaffNo;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            StaffNo = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffNo"] = StaffNo;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");

        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a staff's record from the list";
        }
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}