using System;

namespace ClassLibrary
{
    public class clsSupply
    {
        public bool AvailabilityOfSupplier { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime ToBeDeliveredBy { get; set; }
        public int SupplierID { get; set; }
        public string SupplierContact { get; set; }
        public double PriceOfResource { get; set; }
    }
}