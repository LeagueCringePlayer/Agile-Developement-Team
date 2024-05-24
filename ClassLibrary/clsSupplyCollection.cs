using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsSupplyCollection
    {
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





        //private data member for the list 
        List<clsSupply> mSupplyList = new List<clsSupply>();

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
        public clsSupply ThisSupply { get; set; }
        
    }
}