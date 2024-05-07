using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public int StockId { get; set; }
        public DateTime ArrivedOn { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Boolean Available {  get; set; } 
        public int SupplierId { get; set; } 
    }
}