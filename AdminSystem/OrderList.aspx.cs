﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create an instance of the order collection
        clsOrderCollection1 AnOrder = new clsOrderCollection1();
        //set the data source to list of addresses in the collection
        lstOrderList.DataSource = AnOrder.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderNo";
        //set the data field to display
        lstOrderList.DataTextField = "OrderColour";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderId"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");
    }
}