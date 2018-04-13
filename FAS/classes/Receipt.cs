using System;
namespace FAS
{
    public class Receipt : IReceipt
    {
        private int _id;
        private int _item_id;
        private int _vendor_id;
        private int _quantity;
        private decimal _price = 0.00m;
        private string _official_receipt;
        private DateTime _date_purchased;
        private DateTime _warranty_date;
        
        public int Id {
            get;set;
             
        }
        public int ItemId
        {
            get { return this._item_id; }
            set
            {
                this._item_id = value;
            }
        }
        public int VendorId {
            get { return this._vendor_id; }
            set
            {
                if (value > 0)
                {
                    this._vendor_id = value;
                }
                else
                {
                    throw new ArgumentException("-Please select a vendor");
                }

            }
        }
        public string OfficialReceipt {
            get { return this._official_receipt; }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._official_receipt = value;
                }
                else {
                    throw new ArgumentException("-Invalid Receipt");
                }
            }
        }
        public decimal Price
        {
            get {
                return _price;
            } set {
                if (value > 0)
                {
                    _price = value;
                }
                else {
                    throw new ArgumentException("-Invalid price");
                }
            }
        }
        public int Quantity
        {
            get { return this._quantity; }
            set
            {
                if (value > 0)
                {
                    this._quantity = value;
                }
                else
                {
                    throw new ArgumentException("-Invalid Quantity");
                }
            }
        }

        public DateTime DatePurchased
        {
            get { return this._date_purchased; }
            set {
                
                if (value.Date <= DateTime.Now.Date)
                {
                    this._date_purchased = value;
                }
                else {
                    throw new ArgumentException("-Invalid date of purchase");
                }
                }
        }
        public DateTime WarrantyDate
        {
            
            get { return this._warranty_date; }
            set {
                if (value.Date >= DateTime.Now.Date)
                {
                    this._warranty_date = value;
                }
                else {
                    throw new ArgumentException("-Invalid warranty period");
                }
                }
        }
        public override string ToString()
        {
            return Price.ToString();
        }

    }
}
