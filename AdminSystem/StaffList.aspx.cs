using System;
using System.Collections.Generic;
using System.Web.UI;
using ClassLibrary;

public partial class _1_List : Page
{
    // variable to store the primary key with page level scope
    int StaffID;


    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (!IsPostBack)
        {
            // update the list box
            DisplayStaff();
        }
    }


    void DisplayStaff()
    {
        // create an instance of the Staff collection
        clsStaffCollection StaffCollection = new clsStaffCollection();
        // set the data source to the list of staff in the collection
        lstStaffList.DataSource = StaffCollection.StaffList;
        // set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        // set the data field to display
        lstStaffList.DataTextField = "Name"; // You can customize this as needed
        // bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;
        // redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be edited
        int StaffID;
        // if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            // store the data in the session object
            Session["StaffId"] = StaffID;
            // redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            // if no record has been selected
            lblError.Text = "Please select a record from the list to edit.";
        }
    }


    protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be deleted
        Int32 StaffID;
        // if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            // get the primary key value of the record to delete
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            // store the data in the session object
            Session["StaffId"] = StaffID;
            // redirect to the delete confirmation page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            // if no record has been selected
            lblError.Text = "Please select a record from the list to delete";
        }
    }
}
