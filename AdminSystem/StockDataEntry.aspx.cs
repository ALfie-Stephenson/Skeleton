﻿using System;
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
        //create a new instance of clsStock
        clsStock Stock = new clsStock();
        //capture game ID
        Stock.GameID = txtGameID.Text;
        //store the stock in the stock object
        Session["Stock"] = Stock;
        //navigate to view page
        Response.Redirect("StockViewer.aspx");
    }
}