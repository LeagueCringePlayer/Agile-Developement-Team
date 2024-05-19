using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Customer class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(OrderID);
        //if found
        if (Found == true)
        {
            //display the value of the properties in the form
            lblError.Text = "";
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtStockID.Text = AnOrder.StockID.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtShippingAddress.Text = AnOrder.ShippingAdress;
            txtPaymentMethod.Text = AnOrder.PaymentMethod;
            chkArrival.Checked = AnOrder.Order_Arrival;
        }
        else
        {
            txtCustomerID.Text = "";
            txtStockID.Text = "";
            txtOrderDate.Text = "";
            txtShippingAddress.Text = "";
            txtPaymentMethod.Text = "";
            lblError.Text = "Error: This Id doesn't exist!";
            lblError.Visible = true;
        }

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderiewV.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}