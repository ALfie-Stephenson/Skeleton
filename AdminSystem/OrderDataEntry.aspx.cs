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
    //variavble to store the primary key with page level scope
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        //if this is first time the page is displayed
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (OrderId != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }

        }
    }

    void DisplayOrder()
    {
        //create an instance of the order collection
        clsOrderCollection1 Order = new clsOrderCollection1();
        //find the record to update
        Order.ThisOrder.Find(OrderId);
        //display the data for the record
        txtOrderId.Text = Order.ThisOrder.OrderId.ToString();
        lblOrderNo.Text = Order.ThisOrder.OrderNo.ToString();
        lblOrderSummary.Text = Order.ThisOrder.OrderSummary.ToString();
        lblDateAdded.Text = Order.ThisOrder.DateAdded.ToString();
        lblPrice.Text = Order.ThisOrder.Price.ToString();
        chkInStock.Text = Order.ThisOrder.Stock.ToString();
        lblOrderColour.Text = Order.ThisOrder.Stock.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order summary
        string OrderSummary = lblOrderSummary.Text;
        //capture the order no
        string OrderNo = lblOrderNo.Text;
        //capture the Date Added
        string DateAdded = lblDateAdded.Text;
        //capture Stock check Box
        string Stock = chkInStock.Text;
        //Capture Order colour (Ticket colour)
        string OrderColour = lblOrderColour.Text;
        //Capture the Price
        string Price = lblPrice.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(OrderNo, OrderSummary, OrderColour, Price, DateAdded);
        if (Error == "")
        {
            //capture the order id
            AnOrder.OrderId = OrderId; 
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
            //capture Stock
            AnOrder.Stock = chkInStock.Checked;
            //create a new instance of the order collection 
            clsOrderCollection1 OrderList = new clsOrderCollection1();

            //if this is a new record i.e. OrderId = -1 then add the data
            if (OrderId == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderId);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
            //redirect back to the list page
            Response.Redirect("OrderList.aspx");
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
            lblOrderColour.Text = AnOrder.OrderColour;
            lblOrderNo.Text = AnOrder.OrderNo.ToString();
            lblOrderSummary.Text = AnOrder.OrderSummary;
            lblPrice.Text = AnOrder.Price.ToString();
            lblDateAdded.Text = AnOrder.DateAdded.ToString();
            chkInStock.Text = AnOrder.Stock.ToString(); 
        }
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}