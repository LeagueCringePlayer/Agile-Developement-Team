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
    protected void lstSupplyList_SelectedIndexChanged(object sender, EventArgs e)
    {

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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["SupplyID"] = -1;
        //redirect to the data entry page
        Response.Redirect("SupplyDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 SupplyID;
        //if a record has been selected from the list
        if (lstSupplyList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            SupplyID = Convert.ToInt32(lstSupplyList.SelectedValue);
            //store the data in the session object
            Session["SupplyID"] = SupplyID;
            //redirect to the edit page
            Response.Redirect("SupplyDataEntry.aspx");
        }
        else    //if no record has been selected
        {
            lblError.Text = "At least a record must be selected";
        }
    }
}