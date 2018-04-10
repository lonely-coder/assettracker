using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace FAS
{
    public class SubCategoryRepository
    {
        Connection _connection;
        public SubCategoryRepository() {
            _connection = new Connection();
        }
        public List<SubCategory> SubCategoryList(int category_id) {

            string query = "SELECT * FROM asset_sub_category WHERE asset_category_id = @category_id";

            var list = new List<SubCategory>();

            using (var connection = _connection.GetConnection())
            {
                using (var cmd = new MySqlCommand(query,connection))
                {
                    cmd.Parameters.AddWithValue("@category_id", category_id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) {
                            list.Add(
                                new SubCategory() {
                                    ID = Convert.ToInt32(reader["id"].ToString()),
                                    CategoryId = Convert.ToInt32(reader["asset_category_id"].ToString()),
                                    SubCategoryName = reader["sub_category"].ToString()
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
