﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        StockID = Convert.ToInt32(Session["StockID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the address book collection class
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to delete 
        StockBook.ThisStock.Find(StockID);
        //delete the record
        StockBook.Delete();
        //redirect back to the main page 
        Response.Redirect("StockList.aspx");
    }

    protected void btnNO_Click(object sender, EventArgs e)
    {
        //redirect back to main page
        Response.Redirect("StockList.aspx");
    }
}