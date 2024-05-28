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
        //create a new instance of clsStock
        clsStock Stock = new clsStock();
        //capture game ID
        string GameID = txtGameID.Text;
        //capture ticket location
        string TicketLocation = txtTicketLocation.Text;
        //capture stock amount
        string StockAmount = txtStockAmount.Text;
        //capture ticket price
        string TicketPrice = txtTicketPrice.Text;
        //capture time tickets go on sale
        string TimeTicketsGoOnSale = txtTimeTicketsGoOnSale.Text;
        //capture in stock
        string InStock = chkInStock.Text;
        //variable tpo store any error messages
        string Error = "";
        //validate the data
        Error = Stock.Valid(GameID, TicketLocation, StockAmount, TicketPrice, TimeTicketsGoOnSale);
        if (Error == "")
        {
            //capture the Game ID
            Stock.GameID = GameID;
            //capture the ticket location
            Stock.TicketLocation = TicketLocation;
            //capture the Stock amount
            Stock.StockAmount = Convert.ToInt32(StockAmount);
            //capture the ticket price
            Stock.TicketPrice = Convert.ToInt32(TicketPrice);
            // capture the time tickets go on sale 
            Stock.TimeTicketsGoOnSale = Convert.ToDateTime(TimeTicketsGoOnSale);
            //capture Instock
            Stock.InStock = chkInStock.Checked;
            //create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();
            //set the thisstock property
            StockList.ThisStock = Stock;
            //add the new record 
            StockList.Add();
            //redirect back to the list page
            Response.Redirect("StockList.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Stock class
        clsStock Stock = new clsStock();
        //create a variable to store the primary key
        Int32 StockID;
        //create a variable to store the result of the operation
        Boolean Found = false;
        //get the primary key entered by the user 
        StockID = Convert.ToInt32(txtStockID.Text);
        //find the record
        Found = Stock.Find(StockID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form 
            txtGameID.Text = Stock.GameID;
            txtTicketLocation.Text = Stock.TicketLocation;
            txtStockAmount.Text = Stock.StockAmount.ToString();
            txtTicketPrice.Text = Stock.TicketPrice.ToString();
            txtTimeTicketsGoOnSale.Text = Stock.TimeTicketsGoOnSale.ToString();
            chkInStock.Checked = Stock.InStock;
        }

    }
}