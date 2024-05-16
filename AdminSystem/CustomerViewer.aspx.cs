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

        //create a new instance of clsCustomer
        clsCustomer Customer = new clsCustomer();
        //get the data from the session object
        Customer = (clsCustomer)Session["Customer"];
        //display the Customer Number for this entry
        Response.Write(Customer.CustomerNo);
        //display the Customer Name for this entry
        Response.Write(Customer.CustomerName);
        //display the Customer Address for this entry
        Response.Write(Customer.CustomerAddress);
        //display the Customer Crad Number for this entry
        Response.Write(Customer.CustomerCardNo);
        //display the Customer Card Expiry Date for this entry
        Response.Write(Customer.CustomerExpiryDate);
        //display the Customer CVC for this entry
        Response.Write(Customer.CustomerCVC);
        //display the Customer Join Date for this entry
        Response.Write(Customer.CustomerJoinDate);
        //display the Customer Account Activity for this entry
        Response.Write(Customer.AccountActivity);

    }
}