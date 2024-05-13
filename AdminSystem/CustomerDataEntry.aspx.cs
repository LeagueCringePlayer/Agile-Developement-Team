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

    protected void chkCustomerActive_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer.Email = txtCustomerEmail.Text;
        ACustomer.DateOfBirth = Convert.ToDateTime(DateTime.Now);
        ACustomer.CustomerId = Convert.ToInt32(txtCustomerID.Text);
        ACustomer.Address = txtCustomerAddress.Text;
        ACustomer.FullName = txtCustomerName.Text;
        ACustomer.Password = txtCustomerPassword.Text;
        ACustomer.Active = chkActive.Checked;


        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerView.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
            //create an instance of the Customer class
            clsCustomer ACustomer = new clsCustomer();
            //variable to store the primary key
            Int32 CustomerId;
            //variable to store the result of the find operation
            Boolean Found = false;
            //get the primary key entered by the user
            CustomerId = Convert.ToInt32(txtCustomerID.Text);
            //find the record
            Found = ACustomer.Find(CustomerId);
            //if found
            if (Found == true)
            {
                //display the value of the properties in the form
                lblError.Text = "";
                txtCustomerName.Text = ACustomer.FullName;
                txtCustomerDateOfBirth.Text = ACustomer.DateOfBirth.ToString();
                txtCustomerAddress.Text = ACustomer.Address;
                txtCustomerPassword.Text = ACustomer.Password;
                txtCustomerEmail.Text = ACustomer.Email;
                chkActive.Checked = ACustomer.Active;
            }
            else
            {
                txtCustomerName.Text = "";
                txtCustomerDateOfBirth.Text = "";
                txtCustomerAddress.Text = "";
                txtCustomerPassword.Text = "";
                txtCustomerEmail.Text = "";
                lblError.Text = "Error: This Id doesn't exist!";
                lblError.Visible = true;
            }
        }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}
    




