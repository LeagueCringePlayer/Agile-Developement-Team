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
        //create a new instance of class
        clsStock StockItem = new clsStock();

        //capture item name
        StockItem.ItemName = txtItemName.Text;
        //capture quantity
        StockItem.Quantity = Convert.ToInt32(txtQuantity.Text);
        //capture price
        StockItem.Price = Convert.ToDouble(txtPrice.Text);
        //capture arrived on
        StockItem.ArrivedOn = Convert.ToDateTime(txtArrivedOn.Text);
        //capture supplier id
        StockItem.SupplierId = Convert.ToInt32(txtSupplierId.Text);
        //capture available checkbox
        StockItem.Available = chkAvailable.Checked;

        //store the data in the session object
        Session["StockItem"] = StockItem;

        //navigate to the view page
        Response.Redirect("StockView.aspx");
    }
}