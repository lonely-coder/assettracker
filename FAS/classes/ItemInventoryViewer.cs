using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
namespace FAS.classes
{
    public class ItemInventoryViewer
    {
        Connection _connection;
        public ItemInventoryViewer() {
            _connection = new Connection();
        }
        public DataTable GetItemIventoryPerId(int item_id)
        {
            var _dt = new DataTable();
            try
            {
                string query = $@"SELECT 
                vendors.id as `vendor_id`,
                vendors.vendor_name as `Vendor Name`,
                item_receipt.id as `receipt_id`,
                item_receipt.official_receipt as `Official Receipt`,
                item_receipt.price as `Price`,
                SUM(item_receipt.quantity) As `Quantity`,
                item_receipt.date_purchased `Date Purchased`
                FROM 
                vendors INNER JOIN(
                item_receipt INNER JOIN
                items  
                ON items.id = item_receipt.item_id)
                ON vendors.id = item_receipt.vendor_id
                WHERE items.id = @id GROUP BY item_receipt.official_receipt";

                using (var cmd = new MySqlCommand(query, _connection.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@id", item_id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            _dt.Load(reader);
                        }
                    }

            }
            catch (MySqlException ex)
            {
                throw new ArgumentException("Error loading item details.\nPlease contact your System Administrator.");
            }
            return _dt;
        }
    }
}
