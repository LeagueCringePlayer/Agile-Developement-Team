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
        
            // create a new instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // capture the staff name
            string StaffName = txtStaffName.Text;
            // capture the staff email
            string StaffEmail = txtStaffEmail.Text;
            // capture the staff role
            string StaffRole = txtStaffRole.Text;
            // capture the date hired
            string DateHired = txtDateHired.Text;
            // capture hourly rate
            string HourlyRate = txtHourlyRate.Text;
            // capture Active check box
            string Active = chkIsActive.Checked.ToString();
        // variable to store any error messages
        string Error = "";
            // validate the data
            Error = AStaff.Valid(StaffName, StaffEmail, StaffRole, DateHired, HourlyRate);
            if (Error == "")
            {
                // capture the staff name
                AStaff.Name = StaffName;
                // capture the staff email
                AStaff.StaffEmail = StaffEmail;
                // capture the staff role
                AStaff.Role = StaffRole;
                // capture the date hired
                AStaff.DateHired = Convert.ToDateTime(DateHired);
                // capture hourly rate
                AStaff.HourlyRate = Convert.ToDecimal(HourlyRate);
                // store the staff in the session object
                Session["AStaff"] = AStaff;
                // navigate to the view page
                Response.Redirect("StaffViewer.aspx");
            }
            else
            {
                // display the error message
                lblError.Text = Error;
            }
        

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
                txtStaffName.Text = "";
                txtStaffEmail.Text = "";
                txtStaffRole.Text = "";
                txtDateHired.Text = "";
                chkIsActive.Checked = false;
                txtHourlyRate.Text = "";
                // Display a not found message or log as needed
                lblError.Text = "Staff not found.";
            

        }
    }

}