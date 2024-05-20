using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return OrderList.Count;
            }
            set
            {

            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }



        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrders_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrder Anorder = new clsOrder();
                Anorder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                Anorder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                Anorder.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                Anorder.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                Anorder.ShippingAdress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAdress"]);
                Anorder.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["Payment_Method"]);
                // Check for DBNull before converting to DateTime
                if (DB.DataTable.Rows[Index]["OrderDate"] != DBNull.Value)
                {
                    Anorder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                }
                else
                {
                    // Handle DBNull case appropriately, maybe assign a default value or handle it differently
                    Anorder.OrderDate = DateTime.MinValue; // For example, assign a default value
                }
                
                Anorder.Order_Arrival= Convert.ToBoolean(DB.DataTable.Rows[Index]["Order_Arrival"]);
                mOrderList.Add(Anorder);
                Index++;

            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Payment_Method", mThisOrder.PaymentMethod);
            DB.AddParameter("@ShippingAdress", mThisOrder.ShippingAdress);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Order_Arrival", mThisOrder.Order_Arrival);
            return DB.Execute("sproc_tblOrders_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@ShippingAdress", mThisOrder.ShippingAdress);
            DB.AddParameter("@Payment_Method", mThisOrder.PaymentMethod);
            
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            
            DB.AddParameter("@Order_Arrival", mThisOrder.Order_Arrival);
            DB.Execute("sproc_tblCustomer_Update");
        }
    }
}
