﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
         StockID = Convert.ToInt32(Session["StockID"]);
         if (IsPostBack == false)
        {
            //if this is not a new record
            if(StockID != -1)
            {
                //display the current data for the record
                DisplayStocks();
            }
        }
        //create a new instance of clsstock user
        clsStockUser AnUser = new clsStockUser();
        //get data from the session object
        AnUser = (clsStockUser)Session["AnUser"];
        //display the user name 
        Response.Write("Logged in as: " + AnUser.UserName);

    }

    void DisplayStocks()
    {
        //create an instance of stock collection
        clsStockCollection Stocks = new clsStockCollection();
        //set the data source to list of stocks in the collection
        lstStockList.DataSource = Stocks.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockID";
        //set the Data field to display
        lstStockList.DataTextField = "GameID";
        //bind the dta to the list
        lstStockList.DataBind();    

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StockID"] = -1;
        //redirect to the data entry page 
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited 
        Int32 StockID;
        //if a record has been selected from the list
        if(lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["StockID"]= StockID;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else   //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted 
        Int32 StockID;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["StockID"] = StockID;
            //redirect to the delete page
            Response.Redirect("StockDelete.aspx");
        }
        else // if no record has been selected 
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the address object
        clsStockCollection Stock = new clsStockCollection();
        //retrieve the value of post code from the presentation layer
        Stock.ReportByGameID(txtFilter.Text);
        //set the data source to the list of  addresses in the collection
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockID";
        //set the name of the feild to display
        lstStockList.DataTextField = "GameID";
        //bind the data tpo the list
        lstStockList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the address object
        clsStockCollection Stock = new clsStockCollection();
        //retrieve the value of post code from the presentation layer
        Stock.ReportByGameID("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of  addresses in the collection
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockID";
        //set the name of the feild to display
        lstStockList.DataTextField = "GameID";
        //bind the data tpo the list
        lstStockList.DataBind();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}