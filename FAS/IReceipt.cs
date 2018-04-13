using System;
namespace FAS
{
    interface IReceipt
    {
        int Id {get; set;}
        int ItemId{get; set;}
        int VendorId{get; set;}
        string OfficialReceipt{get; set;}
        decimal Price{get; set;}
        int Quantity{get; set;}
        DateTime DatePurchased{get; set;}
        DateTime WarrantyDate{ get; set; }
    }
}
