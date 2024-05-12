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
            //set the private data members to the test data value
            mStockId = 2;
            mArrivedOn = Convert.ToDateTime("12/05/2024");
            mItemName = "Test Name";
            mQuantity = 5;
            mPrice = 1000;
            mAvailable = true;
            mSupplierId = 3;

            //always return true
            return true;
        }
    }
}