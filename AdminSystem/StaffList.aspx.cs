using System;
using System.Collections.Generic;
using System.Web.UI;
using ClassLibrary;

public partial class _1_List : Page
{
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
        lstStaffList.DataValueField = "Staffid";
        // set the data field to display
        lstStaffList.DataTextField = "Name"; // You can customize this as needed
        // bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // redirect to the add staff page
        Response.Redirect("StaffAdd.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // check if a staff member is selected
        if (lstStaffList.SelectedIndex != -1)
        {
            // redirect to the edit page with the selected staff ID
            int StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            Response.Redirect("StaffEdit.aspx?StaffID=" + StaffID);
        }
        else
        {
            lblError.Text = "Please select a staff member to edit.";
        }
    }

    protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
