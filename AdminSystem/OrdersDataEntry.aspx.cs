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
        //Create a new instance of clsCustomer
        clsOrder Anorder = new clsOrder();
        //capture the customer Date of birth
        string OrderDate = txtOrderDate.Text;
        //capture the customer address
        string Adress = txtShippingAddress.Text;      
        //capture the customer active
        string Active = chkArrival.Text;
        string method = txtPaymentMethod.Text;
        //variable to store any error message
        string Error = "";
        //validate the data 
        Error = Anorder.Valid(Adress, method, OrderDate);
        if (Error == "")
        {
            Anorder.OrderID = OrderID;
            //caprue the customer full name 
            Anorder.PaymentMethod = method;
            //capture the customer date of birth
            Anorder.OrderDate = Convert.ToDateTime(OrderDate);           
            //Capture the customer address
            Anorder.ShippingAdress = Adress;
            
            Anorder.Order_Arrival = chkArrival.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderID == -1)
            {
                OrderList.ThisOrder = Anorder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = Anorder;
                OrderList.Update();
            }
            OrderList.ThisOrder = Anorder;
            OrderList.Add();
            Response.Redirect("OrdersList.aspx");
        }

        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}