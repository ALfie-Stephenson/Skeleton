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

    protected void btnOK_Click1(object sender, EventArgs e)
    {

        //create a new instance of clsCustomer
        clsCustomer Customer = new clsCustomer();
        //capture the customer no
        Customer.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        //capture the customer name
        string CustomerName = txtCustomerName.Text;
        //capture the customer address
        string CustomerAddress = txtCustomerAddress.Text;
        //capture the customer email address
        string CustomerEmailAddress = txtCustomerEmailAddress.Text;
        //capture the card no
        Customer.CustomerCardNo = Convert.ToInt64(txtCustomerCardNo.Text);
        //capture the card expiry
        string CustomerExpiryDate = (txtCustomerExpiryDate.Text);
        //capture the card cvc
        Customer.CustomerCVC = Convert.ToInt32(txtCustomerCVC.Text);
        //capture the join date
        string CustomerJoinDate = (txtCustomerJoinDate.Text);
        //capture the account activity
        Customer.AccountActivity = chkActive.Checked;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = Customer.Valid(CustomerName, CustomerAddress, CustomerEmailAddress, CustomerExpiryDate, CustomerJoinDate);
        if (Error == "")
        {
            //capture the customer name
            Customer.CustomerName = CustomerName;
            //capture the customer address
            Customer.CustomerAddress = CustomerAddress;
            //capture the customer email address
            Customer.CustomerEmailAddress = CustomerEmailAddress;
            //capture the customer expiry date
            Customer.CustomerExpiryDate = Convert.ToDateTime(CustomerExpiryDate);
            //capture the customer join date
            Customer.CustomerJoinDate = Convert.ToDateTime(CustomerJoinDate);
            //capture the card cvc
            Customer.CustomerCVC = Convert.ToInt32(txtCustomerCVC.Text);
            //capture the card no
            Customer.CustomerCardNo = Convert.ToInt64(txtCustomerCardNo.Text);
            //capture the account activity
            Customer.AccountActivity = chkActive.Checked;
            //store the name in the session object
            Session["Customer"] = Customer;
            //navigate to the view page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }




    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer Customer = new clsCustomer();
        //create a variable to store the primary key
        Int32 CustomerNo;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        //find the record
        Found = Customer.Find(CustomerNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerCardNo.Text = Customer.CustomerCardNo.ToString();
            txtCustomerCVC.Text = Customer.CustomerCVC.ToString();
            chkActive.Checked = Customer.AccountActivity;
            txtCustomerJoinDate.Text = Customer.CustomerJoinDate.ToString();
            txtCustomerExpiryDate.Text = Customer.CustomerExpiryDate.ToString();
            txtCustomerAddress.Text = Customer.CustomerAddress;
            txtCustomerName.Text = Customer.CustomerName;
            txtCustomerEmailAddress.Text = Customer.CustomerEmailAddress;
        }
    }
}
