using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAS
{
    public class ReceiptModel:IReceipt
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int VendorId { get; set; }
        public string OfficialReceipt { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime DatePurchased { get; set; }
        public DateTime WarrantyDate { get; set; }
    }
}
