using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//This is the Customer viewer page

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //create a new instance of clsCustomer
        clsCustomer Customer = new clsCustomer();
        //get the data from the session object
        Customer = (clsCustomer)Session["Customer"];
        //display the customer name for this entry
        Response.Write(Customer.CustomerName);

    }
}