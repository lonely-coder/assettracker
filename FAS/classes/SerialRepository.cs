using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace FAS
{
    public class SerialRepository
    {
        Connection _connection;
        List<Serial> _serial_list;

        public SerialRepository()
        {
            _connection = new Connection();
        }
        public SerialRepository(List<Serial> serial_list) {
            _connection = new Connection();
            _serial_list = serial_list;
        }
        
        public List<Serial> GetAllSerialNumbersPerItemId(int item_id) {
            List<Serial> serialList = new List<Serial>();
            string query = @"SELECT * from 
                            item_serials where
                            item_id = @item_id AND 
                            used = 0 AND deleted = 0";
            using (var connection = _connection.GetConnection())
            {
                using (var cmd = new MySqlCommand(query,connection))
                {
                    cmd.Parameters.AddWithValue("@item_id",item_id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            serialList.Add(
                                new Serial() {
                                    Id = int.Parse(reader["id"].ToString()),
                                    SerialNumber = reader["serial_number"].ToString()
                                }
                                );
                        }
                    }
                }

            }
            return serialList;
        }
        private string queryString() {
            string query = @"INSERT INTO item_serials(
                        `item_id`,
                        `item_receipt_id`,
                        `serial_number`,
                        `used`,
                        `deleted`,
                        `date_created`) 
                        values
                        ";
            int x = 0;
            foreach (var list in _serial_list)
            {
                query += @"(@item_id_" + x +
                        ",@official_receipt_id_" + x +
                        ",@serial_number_" + x +
                        ",0,0,now()),";
                x++;
            }
            query = query.ToString().Trim(',');

            return query;
        }
        public bool InsertSerial(int item_id, int receipt_id) {
            bool success = false;

            var query = queryString();

            try
            {
                using (var connection = _connection.GetConnection())
                {
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        int i = 0;
                        foreach (var list in _serial_list)
                        {
                            cmd.Parameters.AddWithValue("@item_id_" + i, item_id);
                            cmd.Parameters.AddWithValue("@official_receipt_id_" + i, receipt_id);
                            cmd.Parameters.AddWithValue("@serial_number_" + i, list.SerialNumber);
                            i++;
                        }
                        success = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new ArgumentException(ex.Message);
            }

            return success;
        }
        public bool ChangeSerialStatus(int id) {
            bool success = false;

            string query = "UPDATE item_serials SET used = 1 where id = @id";

            using (var connection = _connection.GetConnection()) {
                using (var cmd = new MySqlCommand(query,connection)) {
                    cmd.Parameters.AddWithValue("@id",id);
                    success = (cmd.ExecuteNonQuery() > 0);
                }
            }
            return success;
        }

    }
}
