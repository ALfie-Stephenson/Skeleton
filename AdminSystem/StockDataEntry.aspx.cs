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
        Stock.GameID = txtGameID.Text;
        //capture ticket location
        Stock.TicketLocation = txtTicketLocation.Text;
        //capture stock amount
        Stock.StockAmount = Convert.ToInt32(txtStockAmount.Text);
        //capture ticket price
        Stock.TicketPrice = Convert.ToInt32(txtTicketPrice.Text);
        //capture time tickets go on sale
        Stock.TimeTicketsGoOnSale = Convert.ToDateTime(txtTimeTicketsGoOnSale.Text);
        //capture in stock
        Stock.InStock = chkInStock.Checked;
        //store the stock in the stock object
        Session["Stock"] = Stock;
        //navigate to view page
        Response.Redirect("StockViewer.aspx");
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