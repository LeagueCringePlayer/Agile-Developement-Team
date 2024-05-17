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
       //capture Active check box
       ASupply.AvailabilityOfSupplier = chkAvailabilityOfSupplier.Checked;
        
        //store the data in the session object
        Session["ASupply"] = ASupply;
        
        //navigate to the Supply view page
        Response.Redirect("SupplyView.aspx");
    }
}