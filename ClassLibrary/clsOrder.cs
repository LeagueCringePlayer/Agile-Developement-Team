using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Order_Arrival { get; set; }
        public int StockID { get; set; }
        public int StaffID { get; set; }
        public int CustomerID { get; set; }
        public string ShippingAdress { get; set; }
        public string PaymentMethod { get; set; }
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
    }
}