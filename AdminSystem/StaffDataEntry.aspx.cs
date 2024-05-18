using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // Create a new instance of TblStaff
        clsStaff staff = new clsStaff();

        // Capture the data from the form
        staff.StaffId = Convert.ToInt32(txtStaffID.Text); // Ensure StaffID is an integer
        staff.Name = txtStaffName.Text;
        staff.StaffEmail = txtStaffEmail.Text;
        staff.Role = txtStaffRole.Text;
        staff.DateHired = Convert.ToDateTime(txtDateHired.Text); // Ensure DateHired is a valid date
        staff.Active = chkIsActive.Checked;
        staff.HourlyRate = Convert.ToDecimal(txtHourlyRate.Text); // Ensure HourlyRate is a decimal

        // Store the staff data in the session object, if needed
        Session["Staff"] = staff;

        // Optionally, navigate to another page or simply confirm data submission
        // For instance, navigate to a confirmation page or back to the list
        Response.Redirect("StaffView.aspx");
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the staff class
        clsStaff staff = new clsStaff();

        // Create a variable to store the primary key
        int StaffId;

        // Create a variable to store the result of the find operation
        Boolean Found = false;

        // Get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffID.Text); // Ensure conversion is safe

        // Find the record
        Found = staff.Find(StaffId);

        // If found
        if (Found)
        {
            // Display the values of the properties in the form
            txtStaffName.Text = staff.Name;
            txtStaffEmail.Text = staff.StaffEmail;
            txtStaffRole.Text = staff.Role;
            txtDateHired.Text = staff.DateHired.ToString("dd/MM/yyyy"); // Format date appropriately
            chkIsActive.Checked = staff.Active;
            txtHourlyRate.Text = staff.HourlyRate.ToString("N2"); // Format decimal as needed
        }
        else
        {
            // Optionally, clear the fields or display a message if not found
            txtStaffName.Text = "Staff not found.";
            txtStaffEmail.Text = "Staff not found.";
            txtStaffRole.Text = "Staff not found.";
            txtDateHired.Text = "Staff not found.";
            chkIsActive.Checked = false;
            txtHourlyRate.Text = "Staff not found.";
            
        }
    }

}