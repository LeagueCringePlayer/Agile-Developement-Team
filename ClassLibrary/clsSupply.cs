using System;

namespace ClassLibrary
{
    public class clsSupply
    {
        //private data member for the Supply ID property
        private Int32 mSupplyID;

        //SupplyID public property
        public Int32 SupplyID
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplyID;
            }
            set
            {
                //this line of code allows data into the property
                mSupplyID = value;
            }
        }

        //private data member for the Availability Of Supplier
        private Boolean mAvailabilityOfSupplier;
        //Availability Of Supplier public property
        public bool AvailabilityOfSupplier
        {
            get
            {
                //this line of code sends data out of the property
                return mAvailabilityOfSupplier;
            }
            set
            {
                //this line of code allows data into the property
                mAvailabilityOfSupplier = value;
            }
        }


        //private data member for the Date Requested property
        private DateTime mDateRequested;
        //Date Requested public property
        public DateTime DateRequested
        {
            get
            {
                //this line of code sends data out of the property
                return mDateRequested;
            }
            set
            {
                //this line of code allows data into the property
                mDateRequested = value;
            }
        }




        //private data member for the To Be Delivered By property
        private DateTime mToBeDeliveredBy;
        //To Be Delivered By public property
        public DateTime ToBeDeliveredBy
        {
            get
            {
                //this line of code sends data out of the property
                return mToBeDeliveredBy;
            }
            set
            {
                //this line of code allows data into the property
                mToBeDeliveredBy = value;
            }
        }


        //private data member for the Supplier Contact property
        private string mSupplierContact;
        //Supplier Contact public property
        public string SupplierContact
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplierContact;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierContact = value;
            }
        }

        //private data member for the Price Of Resource property
        public double mPriceOfResource;
        //Price Of Resource public property
        public double PriceOfResource
        {
            get
            {
                //this line of code sends data out of the property
                return mPriceOfResource;
            }
            set
            {
                //this line of code allows data into the property
                mPriceOfResource = value;
            }
        }

        /**********************FIND METHOD*******************/

        public bool Find(int SupplyID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Supply ID to search for
            DB.AddParameter("@SupplyID", SupplyID);
            //execute the stored procedure
            DB.Execute("sproc_tblSupply_FilterBySupplyID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mSupplyID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplyID"]);
                mSupplierContact = Convert.ToString(DB.DataTable.Rows[0]["SupplierContact"]);
                mPriceOfResource = Convert.ToDouble(DB.DataTable.Rows[0]["PriceOfResource"]);
                mDateRequested = Convert.ToDateTime(DB.DataTable.Rows[0]["DateRequested"]);
                mAvailabilityOfSupplier = Convert.ToBoolean(DB.DataTable.Rows[0]["AvailabilityOfSupplier"]);
                mToBeDeliveredBy = Convert.ToDateTime(DB.DataTable.Rows[0]["ToBeDeliveredBy"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }
    }
}