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
        AnOrder.Colour = txtOrderColour.Text;
        //Capture the Price
        AnOrder.Price = Convert.ToInt32(txtPrice.Text);
        //store the Order in the session object
        Session["AnOrder"] =AnOrder;
        //navigate to the view page
        Response.Redirect("OrderViewer.aspx");
    }


}