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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupply
        clsSupply ASupply = new clsSupply();

        //capture the supplier contact
        ASupply.SupplierContact = txtSupplierContact.Text;
        //capture the price of resource
        ASupply.PriceOfResource = Convert.ToDouble(txtPriceOfResource.Text);
        //capture the date requested
        ASupply.DateRequested = Convert.ToDateTime(DateTime.Now);
        //capture the to be delivered by
        ASupply.ToBeDeliveredBy = Convert.ToDateTime(DateTime.Now);
       //capture Active check box
       ASupply.AvailabilityOfSupplier = chkAvailabilityOfSupplier.Checked;
        
        //store the data in the session object
        Session["ASupply"] = ASupply;
        
        //navigate to the Supply view page
        Response.Redirect("SupplyView.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsSupply ASupply = new clsSupply();
        //create a variable to store the primary key
        Int32 SupplyID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        SupplyID = Convert.ToInt32(txtSupplierID.Text);
        //find the record
        Found = ASupply.Find(SupplyID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtSupplierContact.Text = ASupply.SupplierContact.ToString();
            txtPriceOfResource.Text = ASupply.PriceOfResource.ToString();
            txtDateRequested.Text = ASupply.DateRequested.ToString();
            txtToBeDeliveredBy.Text = ASupply.ToBeDeliveredBy.ToString();
            chkAvailabilityOfSupplier.Checked = ASupply.AvailabilityOfSupplier;
            lblError.Text = "";
        }
        else
        {
            txtSupplierContact.Text = "";
            txtPriceOfResource.Text = "";
            txtDateRequested.Text = "";
            txtToBeDeliveredBy.Text = "";
            chkAvailabilityOfSupplier.Checked = false;
            lblError.Text = "ERROR: THE ID YOU ENTERED NOT FOUND!";
            lblError.Visible = true;
        }
    }
}