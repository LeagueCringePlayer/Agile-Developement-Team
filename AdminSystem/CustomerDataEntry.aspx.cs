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
        //Create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //Capture the customer full name
        string FullName = txtCustomerName.Text;
        //capture the customer Date of birth
        string DateOfBirth = txtCustomerDateOfBirth.Text;
        //capture the customer address
        string Address = txtCustomerAddress.Text;
        //capture the customer password
        string Password = txtCustomerPassword.Text;
        //capture the customer email
        string Email = txtCustomerEmail.Text;
        //capture the customer active
        string Active = chkActive.Text;
        //variable to store any error message
        string Error = "";
        //validate the data 
        Error = ACustomer.Valid(FullName, Password, Email, Address, DateOfBirth);
        if (Error == "")
        {
            //caprue the customer full name 
            ACustomer.FullName = FullName;
            //capture the customer date of birth
            ACustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //Capture the customer Gender
            ACustomer.Password = Password;
            //Capture the customer address
            ACustomer.Address = Address;
            //capture the customer email
            ACustomer.Email = Email;
            Session["ACustomer"] = ACustomer;
            Response.Redirect("CustomerView.aspx");
        }

        else
        {
            //display the error message
            lblError.Text = Error;
        }

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
    




