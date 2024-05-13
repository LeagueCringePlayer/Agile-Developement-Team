using System;
using System.Collections.Generic;
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
        staff.StaffID = Convert.ToInt32(txtStaffID.Text); // Ensure StaffID is an integer
        staff.StaffName = txtStaffName.Text;
        staff.StaffEmail = txtStaffEmail.Text;
        staff.StaffRole = txtStaffRole.Text;
        staff.DateHired = Convert.ToDateTime(txtDateHired.Text); // Ensure DateHired is a valid date
        staff.IsActive = chkIsActive.Checked;
        staff.HourlyRate = Convert.ToDecimal(txtHourlyRate.Text); // Ensure HourlyRate is a decimal

        // Store the staff data in the session object, if needed
        Session["Staff"] = staff;

        // Optionally, navigate to another page or simply confirm data submission
        // For instance, navigate to a confirmation page or back to the list
        Response.Redirect("StaffView.aspx");
    }

}