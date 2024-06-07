using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnStockLogin_Click(object sender, EventArgs e)
    {
        //redirect the user to the stock login page
        Response.Redirect("StockLogin.aspx");
    }

    protected void btnCustomerLogin_Click(object sender, EventArgs e)
    {
        //redirect to the customer staff login page
        Response.Redirect("CustomerStaffLoginPage.aspx");
    }
    protected void btnStaffLogin_Click(object sender, EventArgs e)
    {
        //Redirect the users to the designated staff login page
        Response.Redirect("StaffLogin.aspx");
    }
}