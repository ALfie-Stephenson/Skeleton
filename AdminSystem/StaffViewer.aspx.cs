using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Check if the session object exists and is of type clsStaff
        if (Session["Staff"] != null && Session["Staff"] is clsStaff)
        {
            // Cast the session object to clsStaff and assign it to Staff
            clsStaff Staff = (clsStaff)Session["Staff"];
            //display the Staff number for this entry
            Response.Write(Staff.StaffNo);
            //display the Staff Name for this entry
            Response.Write(Staff.StaffName);
            //display the Staff Role for this entry
            Response.Write(Staff.StaffRole);
            //display the Staff Start date for this entry
            Response.Write(Staff.StaffStart);
            //display the Staff Permission for this entry
            Response.Write(Staff.StaffPermission);
            //display the Staff On Shift Data for this entry
            Response.Write(Staff.StaffOnShift);
            //display the Staff Data Delete Data for this entry
            Response.Write(Staff.StaffDataDelete);
        }
    }
}
/*{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff Staff = new clsStaff();
        //get the data from the session object
        Staff = (clsStaff)Session["Staff"];
        //display the Staff number for this entry
        Response.Write(Staff.StaffNo);
        //display the Staff Name for this entry
        Response.Write(Staff.StaffName);
        //display the Staff Role for this entry
        Response.Write(Staff.StaffRole);
        //display the Staff Start date for this entry
        Response.Write(Staff.StaffStart);
        //display the Staff Permission for this entry
        Response.Write(Staff.StaffPermission);
        //display the Staff On Shift Data for this entry
        Response.Write(Staff.StaffOnShift);
        //display the Staff Data Delete Data for this entry
        Response.Write(Staff.StaffDataDelete);
    }
}*/