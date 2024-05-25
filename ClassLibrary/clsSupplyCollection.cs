using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsSupplyCollection
    {
        //private data member for the list
        List<clsSupply> mSupplyList = new List<clsSupply>();
        //private member data for thisSupply
        clsSupply mThisSupply = new clsSupply();

        //constructor for the class
        public clsSupplyCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count 
            Int32 RecordCount = 0;
            //object for the data connect 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblSupply_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Supply
                clsSupply ASupply = new clsSupply();
                //read in the fields for the current record
                ASupply.SupplyID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplyID"]);
                ASupply.SupplierContact = Convert.ToString(DB.DataTable.Rows[Index]["SupplierContact"]);
                ASupply.PriceOfResource = Convert.ToDouble(DB.DataTable.Rows[Index]["PriceOfResource"]);
                ASupply.DateRequested = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateRequested"]);
                ASupply.AvailabilityOfSupplier = Convert.ToBoolean(DB.DataTable.Rows[Index]["AvailabilityOfSupplier"]);
                ASupply.ToBeDeliveredBy = Convert.ToDateTime(DB.DataTable.Rows[Index]["ToBeDeliveredBy"]);
                //add the record to the private data member
                mSupplyList.Add(ASupply);
                //point at the next record
                Index++;
            }
        }
      
        //public property for the Supply List
        public List<clsSupply> SupplyList
        {
            get
            {
                //return the private data
                return mSupplyList;
            }
            set
            {
                //set the private data
                mSupplyList = value;
            }
        }

        //public property for Count
        public int Count
        {
            get
            {
                //return the count of the list
                return mSupplyList.Count;
            }
            set
            {
                //we will come back to this later
            }
        }
        public clsSupply ThisSupply
        {
            get
            {
                //return the private data
                return mThisSupply;
            }
            set
            {
                //set the private data
                mThisSupply = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisSupply
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@SupplierContact", mThisSupply.SupplierContact);
            DB.AddParameter("@PriceOfResource", mThisSupply.PriceOfResource);
            DB.AddParameter("@DateRequested", mThisSupply.DateRequested);
            DB.AddParameter("@AvailabilityOfSupplier", mThisSupply.AvailabilityOfSupplier);
            DB.AddParameter("@ToBeDeliveredBy", mThisSupply.ToBeDeliveredBy);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblSupply_Insert");
        }
    }
}