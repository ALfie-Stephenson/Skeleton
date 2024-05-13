using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock Stock = new clsStock();
        //get the data from the session object 
        Stock = (clsStock)Session["Stock"];
        //display the Game ID for this entry
        Response.Write(Stock.GameID);
        //display the Ticket location for this entry
        Response.Write(Stock.TicketLocation);
        //display the stock amount for this entry
        Response.Write(Stock.StockAmount);
        //display the ticket price for this entry
        Response.Write(Stock.TicketPrice);
        //display the time tickets go on sale for this entry
        Response.Write(Stock.TimeTicketsGoOnSale);
        //display the in stock for this entry
        Response.Write(Stock.InStock);
    }
}