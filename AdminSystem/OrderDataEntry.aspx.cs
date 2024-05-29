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
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order summary
        AnOrder.OrderSummary = txtOrderSummary.Text;
        //capture the order no
        AnOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);
        //capture the Date Added
        AnOrder.DateAdded = Convert.ToDateTime(DateTime.Now);
        //capture Stock check Box
        AnOrder.Stock = chkInStock.Checked;
        //Capture Order colour (Ticket colour)
        AnOrder.OrderColour = txtOrderColour.Text;
        //Capture the Price
        AnOrder.Price = Convert.ToInt32(txtPrice.Text);
        //store the Order in the session object
        Session["AnOrder"] =AnOrder;
        //navigate to the view page
        Response.Redirect("OrderViewer.aspx");
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