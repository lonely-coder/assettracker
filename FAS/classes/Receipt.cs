using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
namespace FAS
{
    public class Receipt 
    {
        private int _id;
        private int _item_id;
        private int _vendor_id;
        private int _quantity;
        private double _price = 0.00;
        private string _official_receipt;
        private DateTime _date_purchased;
        private DateTime _warranty_date;
        private bool _success = false;
        
        public int Id {
            get { return this._id; }
            set {
                if (value > 0)
                {
                    this._id = value;
                }
                else {
                    throw new ArgumentException("Invalid Receipt Id");
                }
             
            }
        }
        public int ItemId
        {
            get { return this._item_id; }
            set
            {
                if (value > 0)
                {
                    this._item_id = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Item Id");
                }

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
        public double Price
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
