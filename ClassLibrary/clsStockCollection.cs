﻿using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStockCollection
    {
        //constructor for the class
        public clsStockCollection() 
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records found from the stored proc
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock item
                clsStock StockItem = new clsStock();
                //read in fields for the current record
                StockItem.ArrivedOn = Convert.ToDateTime(DB.DataTable.Rows[Index]["ArrivedOn"]);
                StockItem.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                StockItem.ItemName = Convert.ToString(DB.DataTable.Rows[Index]["ItemName"]);
                StockItem.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                StockItem.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                StockItem.StockId = Convert.ToInt32(DB.DataTable.Rows[Index]["StockId"]);
                StockItem.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                //add the record to the private data memeber list
                mStockList.Add(StockItem);
                //next record
                Index++;
            }

        }

        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();   
        //private data member for thisStock
        clsStock mThisStock = new clsStock();


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
        //public property for ThisStock
        public clsStock ThisStock 
        {
            get
            {
                //return private data member
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisStock
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ItemName", mThisStock.ItemName);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.AddParameter("@ArrivedOn", mThisStock.ArrivedOn);
            DB.AddParameter("@SupplierId", mThisStock.SupplierId);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

    }
}