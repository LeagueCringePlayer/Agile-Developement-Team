using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Expressions;
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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of stock class
        clsStock StockItem = new clsStock();
        //create a variable to store primary key
        Int32 StockId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary entered by the user
        StockId = Convert.ToInt32(txtStockId.Text);
        //find the record
        Found = StockItem.Find(StockId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in from
            txtStockId.Text = StockItem.StockId.ToString();
            txtItemName.Text = StockItem.ItemName;
            txtQuantity.Text = StockItem.Quantity.ToString();
            txtPrice.Text = StockItem.Price.ToString();
            txtArrivedOn.Text = StockItem.ArrivedOn.ToString();
            txtSupplierId.Text = StockItem.SupplierId.ToString();   
            chkAvailable.Checked = StockItem.Available;
            lblError.Text = "";
        }
        else
        {
            txtStockId.Text = "";
            txtItemName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtArrivedOn.Text = "";
            txtSupplierId.Text = "";
            chkAvailable.Checked = false;
            lblError.Text = "Record Not Found";
        }


    }
}