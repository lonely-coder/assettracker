using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
namespace FAS
{
    class Vendors :DB
    {

        private int _id;
        private string _vendorName;
        private string _address;
        private string _contactNumber;
        private string _emailAddress;
        private string _tags;
        private string _parameter;
        private DataTable _vendorsDT;
        private DataTable _dt;

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
        public string Parameter {
            get { return this._parameter; }
            set { this._parameter = value; }
        }
        public void CreateVendor() {
           
                this.Query = @"INSERT into vendors(
                    `id`,
                    `vendor_name`,
                    `address`,
                    `contact_number`,
                    `email_add`,
                    `tags`,
                    `date_created`)
                    VALUES(
                    null,
                    @vendorName,
                    @address,
                    @contactNumber,
                    @emailAdd,
                    @tags,
                    now())";

                if (this.OpenConnection() == true) {

                    cmd = new MySqlCommand(this.Query,this.connection);
                    cmd.Parameters.AddWithValue("@vendorName",this.VendorName);
                    cmd.Parameters.AddWithValue("@address", this.Address);
                    cmd.Parameters.AddWithValue("@contactNumber", this.ContactNumber);
                    cmd.Parameters.AddWithValue("@emailAdd", this.EmailAddress);
                    cmd.Parameters.AddWithValue("@tags", this.Tags);
                    cmd.ExecuteNonQuery();

                    this.CloseConnection();
                }

          
        }
        public void UpdateVendor() {

            this.Query = $@"UPDATE vendors SET
                `vendor_name` = @vendorName,
                `address` = @address,
                `contact_number` = @contactNumber,
                `email_add` = @emailAdd,
                `tags` = @tags,
                `date_updated` = now()
                WHERE id  = @id";

            if (this.OpenConnection() == true) {
                cmd = new MySqlCommand(this.Query, this.connection);
                cmd.Parameters.AddWithValue("@vendorName", this.VendorName);
                cmd.Parameters.AddWithValue("@address", this.Address);
                cmd.Parameters.AddWithValue("@contactNumber", this.ContactNumber);
                cmd.Parameters.AddWithValue("@emailAdd", this.EmailAddress);
                cmd.Parameters.AddWithValue("@tags", this.Tags);
                cmd.Parameters.AddWithValue("@id",this.ID);
                cmd.ExecuteNonQuery();

                this.CloseConnection();

            }
        }
        public DataTable SelectAllVendords() {

            this.Query = @"SELECT id as `pkVendorID`,
                vendor_name as `Vendor`,
                address as `Address`,
                CONCAT(contact_number,'/',email_add) AS Contacts,
                tags as `Tags` FROM vendors";

            this._vendorsDT = this.Select();

            return this._vendorsDT;
        }
        public DataTable SelectVendor()
        {
            this.Query = $@"SELECT id as `pkVendorID`,
                vendor_name as `Vendor`,
                address as `Address`,
                CONCAT(contact_number,'/',email_add) AS Contacts,
                tags as `Tags` FROM vendors
                WHERE vendor_name LIKE @parameter";
         
                if (this.OpenConnection() == true)
                {
                    cmd = new MySqlCommand(this.Query, this.connection);
                    da = new MySqlDataAdapter(cmd);
                    this._dt = new DataTable();
                    cmd.Parameters.AddWithValue("@parameter","%" +this._parameter+ "%");
                    cmd.Prepare();
                    da.SelectCommand = cmd;
                    da.Fill(this._dt);
                     this.CloseConnection();

            }
                return this._dt;

        }

    }
}
