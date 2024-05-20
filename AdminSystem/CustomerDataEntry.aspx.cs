using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a nw instance of clsCustomer
        clsCustomer Customer = new clsCustomer();
        //capture the customer no
        Customer.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        //capture the customer name
        Customer.CustomerName = txtCustomerName.Text;
        //capture the customer address
        Customer.CustomerAddress = txtCustomerAddress.Text;
        //capture the card no
        Customer.CustomerCardNo = Convert.ToInt64(txtCustomerCardNo.Text);
        //capture the card expiry
        Customer.CustomerExpiryDate = Convert.ToDateTime(txtCustomerExpiryDate.Text);
        //capture the card cvc
        Customer.CustomerCVC = Convert.ToInt32(txtCustomerCVC.Text);
        //capture the join date
        Customer.CustomerJoinDate = Convert.ToDateTime(DateTime.Now);
        //capture the account activity
        Customer.AccountActivity = chkActive.Checked;
        //store the name in the session object
        Session["Customer"] = Customer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");

    }
}