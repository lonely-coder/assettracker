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

        private int _last_insert_id = 0;

        public ReceiptRepository()
        {
            _connection = new Connection();
        }
        public ReceiptRepository(Receipt receipt) {
            _connection = new Connection();
            _receipt = receipt;
        }
        public int LastInsertId() {
            return _last_insert_id;
        }
        public List<Double> ItemPriceRange(int item_id) {

            List<Double> itemPrices = new List<Double>();
            string query = @"SELECT DISTINCT price from item_receipt WHERE item_id = @item_id";
            using (var connection = _connection.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@item_id", item_id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) {
                            itemPrices.Add(Convert.ToDouble(reader["price"].ToString()));
                        }
                    }
                }
            }
            return itemPrices;
        }
        public List<Receipt> GetPrice(int id)
        {
            double price = 0.00;
            List<Receipt> _priceList = new List<Receipt>();
            string query = @"SELECT price from item_receipt WHERE id = (SELECT item_receipt_id from item_serials where id = @id) LIMIT 1";
            using (var connection = _connection.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    price = Convert.ToDouble(cmd.ExecuteScalar());
                    _priceList.Add(new Receipt() { Price = price });
                }
            }
            return _priceList;
        }
        public void InsertReceipt(int item_id)
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
                        cmd.Parameters.AddWithValue("@itemId", item_id);
                        cmd.Parameters.AddWithValue("@vendor", _receipt.VendorId);
                        cmd.Parameters.AddWithValue("@receipt", _receipt.OfficialReceipt);
                        cmd.Parameters.AddWithValue("@price", _receipt.Price);
                        cmd.Parameters.AddWithValue("@quantity", _receipt.Quantity);
                        cmd.Parameters.AddWithValue("@datePurchased",_receipt.DatePurchased);
                        cmd.Parameters.AddWithValue("@warranty", _receipt.WarrantyDate);
                        cmd.ExecuteNonQuery();
                        _last_insert_id = Convert.ToInt32(cmd.LastInsertedId);
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
