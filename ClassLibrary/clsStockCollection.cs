using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStockCollection
    {

        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();   


        public List<clsStock> StockList 
        {
            get
            {
                //return private data member
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value; 
            } 
        }

        public int Count 
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //to be done later
            } 
        }
        public clsStock ThisStock { get; set; }
    }
}