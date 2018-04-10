using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace FAS
{
    public class PositionRepository
    {
        Connection _connection;
        public PositionRepository() {
            _connection = new Connection();
        }

        public List<Position> PositionList(int department_id) {

            List<Position> list = new List<Position>();
            string query = "SELECT * from positions WHERE department_id = @department_id";

            using (var connection = _connection.GetConnection())
            {
                using (var cmd = new MySqlCommand(query,connection))
                {
                    cmd.Parameters.AddWithValue("@department_id", department_id);
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read())
                        {
                            list.Add(
                                new Position() {
                                    Id = Convert.ToInt32(reader["id"].ToString()),
                                    DepartmentId = Convert.ToInt32(reader["department_id"].ToString()),
                                    PositionName = reader["position_name"].ToString()
                                }
                                );
                        }
                    }
                }
            }

                return list;
        }
    }
}
