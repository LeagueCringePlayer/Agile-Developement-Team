﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Expressions;
using ClassLibrary;
using Microsoft.SqlServer.Server;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of class
        clsStock StockItem = new clsStock();
        
        //capture the data using string variables to pass these into the valid method
        string ItemName = txtItemName.Text;
        string Quantity = txtQuantity.Text;
        string Price = txtPrice.Text;
        string ArrivedOn = txtArrivedOn.Text;
        string SupplierId = txtSupplierId.Text;
        string Available = chkAvailable.Text;

        //variable to store error messages
        string Error = "";

        //validate the data by passing the above string vars
        //if valid is OK they will be stored as the intended data type
        Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
        if (Error == "")
        {
            //capture all the data
            StockItem.ItemName = ItemName;
            StockItem.ArrivedOn = Convert.ToDateTime(ArrivedOn);
            StockItem.Quantity = Convert.ToInt32(Quantity);
            StockItem.Price = Convert.ToDouble(Price);
            StockItem.SupplierId = Convert.ToInt32(SupplierId);
            StockItem.Available = chkAvailable.Checked;
            //create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();
            //set the ThisStock property
            StockList.ThisStock = StockItem;
            //add the new record
            StockList.Add();
            //redirect back to the list page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display an error message if the valid fails 
            lblError.Text = Error;
        }
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