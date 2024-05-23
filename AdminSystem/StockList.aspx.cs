using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStock();
        }
    }

    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    void DisplayStock()
    {
        //create an instance of the stock collection
        clsStockCollection StockItems = new clsStockCollection();
        //set the data source to list of addresses in collection
        lstStockList.DataSource = StockItems.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockId";
        //set the data field to display
        lstStockList.DataTextField = "ItemName";
        //bind the data to the list
        lstStockList.DataBind();
    }


    
}