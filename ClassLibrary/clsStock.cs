using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the stock id property
        private Int32 mStockId;
        //stock id public property
        public int StockId 
        {
            get
            {
                //sends data out of the property
                return mStockId;
            }
            set
            {
                //allows data into the property
                mStockId = value;
            } 
        }

        //private data member for the arrived on property
        private DateTime mArrivedOn;
        //arrived on public property
        public DateTime ArrivedOn 
        { 
            get
            {
                //sends data out of the property
                return mArrivedOn;
            }
            set
            {
                //allows data into the property
                mArrivedOn = value;
            }
        }

        //private data member for the item name property
        private String mItemName;
        //item name public property
        public string ItemName 
        {
            get
            {
                //sends data out of the property
                return mItemName;
            }
            set
            {
                //allows data into the property
                mItemName = value;
            }
        }

        //private data member for the quantity property
        private Int32 mQuantity;
        //quantity public property
        public int Quantity 
        {
            get
            {
                //sends data out of the property
                return mQuantity;
            }
            set
            {
                //allows data into the property
                mQuantity = value;
            }
        }

        //private data member for the price property
        private double mPrice;
        //price public property
        public double Price 
        {
            get
            {
                //sends data out of the property
                return mPrice;
            }
            set
            {
                //allows data into the property
                mPrice = value;
            }
        }

        //private data member for the available property
        private Boolean mAvailable;
        //available public property
        public Boolean Available 
        {
            get
            {
                //sends data out of the property
                return mAvailable;
            }
            set
            {
                //allows data into the property
                mAvailable = value;
            }
        }

        //private data member for the supplier id property
        private Int32 mSupplierId;
        //supplier id public property
        public int SupplierId 
        {
            get
            {
                //sends data out of the property
                return mSupplierId;
            }
            set
            {
                //allows data into the property
                mSupplierId = value;
            }
        }



        public bool Find(int stockId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the stock id to search for
            DB.AddParameter("@StockId", stockId);
            //execute stored procedure
            DB.Execute("sproc_tblStock_FilterByStockId");

            //if one record is found (Either one or zero)
            if (DB.Count == 1)
            {
                //copy data from the database to the private data members
                mStockId = Convert.ToInt32(DB.DataTable.Rows[0] ["StockId"]);
                mArrivedOn = Convert.ToDateTime(DB.DataTable.Rows[0]["ArrivedOn"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);

                //return that everything is OK
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}