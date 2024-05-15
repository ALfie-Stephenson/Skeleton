using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    public object txtCustomerName { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a nw instance of clsCustomer
        clsCustomer Customer = new clsCustomer();
        //capture the customer name
        Customer.CustomerName = txtCustomerName.Text;
        //store the name in the session object
        Session["Customer"] = Customer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");

    }
}