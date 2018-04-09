using System;
namespace FAS
{
    public class Vendors
    {
        private int _id;
        private string _vendorName;
        private string _address;
        private string _contactNumber;
        private string _emailAddress;
        private string _tags;
        
        public int ID {

            get { return this._id; }
            set {
                if (value > 0)
                {
                    this._id = value;
                }
                else {
                    throw new ArgumentException("Invalid Vendor ID");
                }
            }
        }
        public string VendorName {
            get { return this._vendorName; }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._vendorName =value;
                }
                else {
                    throw new ArgumentException("Vendor Name is Required");
                }
            }
        }
        public string Address {
            get { return this._address; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._address = value;
                }
                else
                {
                    throw new ArgumentException("Address is Required");
                }
            }
        }
        public string ContactNumber
        {
            get { return this._contactNumber; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._contactNumber = value;
                }
                else
                {
                    throw new ArgumentException("Contact Number is Required");
                }
            }
        }
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set
            {   
                    this._emailAddress = value;   
            }
        }

        public string Tags
        {
            get { return this._tags; }
            set
            {
                this._tags = value;
            }
        }
    }
}
