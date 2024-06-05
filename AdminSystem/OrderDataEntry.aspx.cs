using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order summary
        string OrderSummary = txtOrderSummary.Text;
        //capture the order no
        string OrderNo = txtOrderNo.Text;
        //capture the Date Added
        string DateAdded = txtDateAdded.Text;
        //capture Stock check Box
        string Stock = chkInStock.Text;
        //Capture Order colour (Ticket colour)
        string OrderColour = txtOrderColour.Text;
        //Capture the Price
        string Price = txtPrice.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
        if (Error == "")
        {
            //capture the order Summary
            AnOrder.OrderSummary = OrderSummary;
            //capture the order no
            AnOrder.OrderNo = OrderNo;
            //capture the Date
            AnOrder.DateAdded = Convert.ToDateTime(DateAdded);
            //capture the order colour 
            AnOrder.OrderColour = OrderColour;
            //capture the price
            AnOrder.Price = Price;
            //store the order in the session object
            Session["AnOrder"] = AnOrder;
            //navigate to the view page
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //create a variable to store the primary key
        Int32 OrderId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId  = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form 
            txtOrderColour.Text = AnOrder.OrderColour;
            txtOrderNo.Text = AnOrder.OrderNo.ToString();
            txtOrderSummary.Text = AnOrder.OrderSummary;
            txtPrice.Text = AnOrder.Price.ToString();
            txtDateAdded.Text = AnOrder.DateAdded.ToString();
            chkInStock.Text = AnOrder.Stock.ToString(); 
        }
    }
}