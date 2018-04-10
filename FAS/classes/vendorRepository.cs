using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace FAS
{
    public class VendorRepository
    {
        Connection _connection;
        Vendors _vendors;
        public VendorRepository() {
            _connection = new Connection();
        }
        public VendorRepository(Vendors vendors)
        {
            _connection = new Connection();
            _vendors = vendors;
        }
        public List<Vendors> VendorList() {
            List<Vendors> list = new List<Vendors>();

            string query = @"SELECT id ,
                vendor_name 
                FROM vendors";

            using (var connection = _connection.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Vendors()
                            {
                                ID = Convert.ToInt32(reader["id"].ToString()),
                                VendorName = reader["vendor_name"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }
        public Vendors getById(int vendor_id)
        {
            Vendors vendor = new Vendors();

            string query = @"SELECT *
                FROM vendors where id = @id LIMIT 1";

            using (var connection = _connection.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id",vendor_id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            vendor.ID = Convert.ToInt32(reader["id"].ToString());
                            vendor.VendorName = reader["vendor_name"].ToString();
                            vendor.Address = reader["address"].ToString();
                            vendor.ContactNumber = reader["contact_number"].ToString();
                            vendor.EmailAddress = reader["email_add"].ToString();
                            vendor.Tags = reader["tags"].ToString();
                        }
                    }
                }
            }
            return vendor;
            
        }
        public List<Vendors> getVendorByEntity(string vendor_name)
        {
            List<Vendors> list = new List<Vendors>();

            string query = @"SELECT *
                FROM vendors where vendor_name LIKE @vendor_name";

            using (var connection = _connection.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@vendor_name",'%'+ vendor_name+'%');
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Vendors()
                            {
                                ID = Convert.ToInt32(reader["id"].ToString()),
                                VendorName = reader["vendor_name"].ToString(),
                                Address = reader["address"].ToString(),
                                ContactNumber = reader["contact_number"].ToString(),
                                EmailAddress = reader["email_add"].ToString(),
                                Tags = reader["tags"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }
        public void CreateVendor()
        {

            string query = @"INSERT into vendors(
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



            using (var connection = _connection.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@vendorName", _vendors.VendorName);
                    cmd.Parameters.AddWithValue("@address", _vendors.Address);
                    cmd.Parameters.AddWithValue("@contactNumber", _vendors.ContactNumber);
                    cmd.Parameters.AddWithValue("@emailAdd", _vendors.EmailAddress);
                    cmd.Parameters.AddWithValue("@tags", _vendors.Tags);
                    cmd.ExecuteNonQuery();
                } 
            }
        }
        public void UpdateVendor()
        {

            string query = $@"UPDATE vendors SET
                `vendor_name` = @vendorName,
                `address` = @address,
                `contact_number` = @contactNumber,
                `email_add` = @emailAdd,
                `tags` = @tags,
                `date_updated` = now()
                WHERE id  = @id";

            using (var connection = _connection.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", _vendors.ID);
                    cmd.Parameters.AddWithValue("@vendorName", _vendors.VendorName);
                    cmd.Parameters.AddWithValue("@address", _vendors.Address);
                    cmd.Parameters.AddWithValue("@contactNumber", _vendors.ContactNumber);
                    cmd.Parameters.AddWithValue("@emailAdd", _vendors.EmailAddress);
                    cmd.Parameters.AddWithValue("@tags", _vendors.Tags);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
