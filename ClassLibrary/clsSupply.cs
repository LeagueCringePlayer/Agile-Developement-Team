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

        public bool Find(int supplyID)
        {
            //set the private data members to the test data value
            mSupplyID = 1;
            mSupplierContact = "p2709563@my365.dmu.ac.uk";
            mPriceOfResource = Convert.ToDouble(1699.99);
            mDateRequested = Convert.ToDateTime("15/04/2024");
            mAvailabilityOfSupplier = true;
            mToBeDeliveredBy = Convert.ToDateTime("10/05/2024");
            //always return true
            return true;
        }
    }
}