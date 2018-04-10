using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace FAS
{
    public class CategoryRepository
    {
        Connection _connection;
        public CategoryRepository() {
            _connection = new Connection();
        }

        public List<Category> CategoryList() {
            List<Category> list = new List<Category>();

            string query = @"SELECT * FROM asset_category";
            using (var connection = _connection.GetConnection()) {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            list.Add(new Category()
                            {
                                ID = Convert.ToInt32(reader["id"].ToString()),
                                CategoryName = reader["category"].ToString()
                            });
                        }
                    }
                }
            }

                return list;
        }

    }
}
