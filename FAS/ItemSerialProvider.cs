using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace FAS
{
    class ItemSerialProvider
    {
        Connection _connection;
        public ItemSerialProvider() {
            _connection = new Connection();
        }
        
        public bool VerifyIfSerialIsAvailable(int item_id, string serial_number)
        {
            string query = "SELECT count(*) from item_serials WHERE item_id = @item_id AND serial_number = @serial_number AND (used = 0 AND deleted = 0)";
            //Serial serial = new Serial();
            try
            {
                using (var connection = _connection.GetConnection())
                {
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@item_id", item_id);
                        cmd.Parameters.AddWithValue("@serial_number", serial_number);
                        return System.Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }
        public List<Serial> GetSerialNumbers(int item_id,string serial)
        {
            string query = "SELECT * from item_serials WHERE item_id = @item_id AND serial_number LIKE @serial_number AND used = 0 AND deleted = 0";

            List<Serial> serial_list = new List<Serial>();

            using (var connection = _connection.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@item_id", item_id);
                    cmd.Parameters.AddWithValue("@serial_number", "%" + serial + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            serial_list.Add(
                                    new Serial()
                                    {
                                        Id = int.Parse(reader["id"].ToString()),
                                        SerialNumber = reader["serial_number"].ToString()
                                    });
                        }
                    }
                }
            }

        return serial_list;
        }
    }
}
