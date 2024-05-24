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
            DisplaySupplies();
        }
    }
    void DisplaySupplies()
    {
        //create an instance of the Supply collection 
        clsSupplyCollection Supplies = new clsSupplyCollection();  
        //set the data source to list of supplies in the collection 
        lstSupplyList.DataSource = Supplies.SupplyList;
        //set the name of the primary key
        lstSupplyList.DataValueField = "SupplyID";
        //set the data field to display
        lstSupplyList.DataTextField = "SupplierContact";
        //bind the data to the list
        lstSupplyList.DataBind();
    }
}