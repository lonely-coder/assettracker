using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace FAS
{
    public class ReceiptRepository
    {
        Connection _connection;
        Receipt _receipt;
        public ReceiptRepository() {

        }
        public ReceiptRepository(Connection connection)
        {
            this._connection = connection;
         
        }
        public ReceiptRepository(Connection connection,Receipt receipt) {
            this._connection = connection;
            this._receipt = receipt;
        }

        public void InsertReceipt()
        {
            string query = @"INSERT into item_receipt(
                            `item_id`,
                            `vendor_id`,
                            `official_receipt`,
                            `price`,
                            `quantity`,
                            `date_purchased`,
                            `warranty_date`,
                            `date_created`) VALUES (
                            @itemId,
                            @vendor,
                            @receipt,
                            @price,
                            @quantity,
                            @datePurchased,
                            @warranty,
                            now());";
            try
            {
                using (MySqlConnection connection = _connection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@itemId", this._receipt.ItemId);
                        cmd.Parameters.AddWithValue("@vendor", this._receipt.VendorId);
                        cmd.Parameters.AddWithValue("@receipt", this._receipt.OfficialReceipt);
                        cmd.Parameters.AddWithValue("@price", this._receipt.Price);
                        cmd.Parameters.AddWithValue("@quantity", this._receipt.Quantity);
                        cmd.Parameters.AddWithValue("@datePurchased", this._receipt.DatePurchased);
                        cmd.Parameters.AddWithValue("@warranty", this._receipt.WarrantyDate);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new ArgumentException(ex.ToString());
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }
        }
        }
}
