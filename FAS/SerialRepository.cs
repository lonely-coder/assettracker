using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace FAS
{
    class SerialRepository
    {
        Connection _connection;
        List<Serial> _serial;
        public SerialRepository(Connection connection,List<Serial> serial) {
            _connection = connection;
            _serial = serial;
        }

        public bool InsertSerial() {
            bool success = false;
            string query = @"INSERT INTO item_serials(
                        `item_id`,
                        `item_receipt_id`,
                        `serial_number`,
                        `date_created`) 
                        values(
                        @item_id,
                        @official_receipt_id,
                        @serial_number,
                        now())";
            try
            {
                using (var connection = _connection.GetConnection()) {
                    using (var cmd = new MySqlCommand(query, connection)) {
                        int i = 0;
                        foreach (var list in _serial) {
                            cmd.Parameters.AddWithValue("@item_id_" + i, list.ItemId);
                            cmd.Parameters.AddWithValue("@official_receipt_id_" + i, list.ReceiptId);
                            cmd.Parameters.AddWithValue("@serial_number_" + i, list.SerialNumber);
                            i++;
                        }
                        
                        success = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return success;
        }

    }
}
