using System;
using System.Collections.Generic;

using MySql.Data.MySqlClient;
namespace FAS
{
    public class DepartmentsRepository
    {
        Connection _connection;
        public DepartmentsRepository() {
            _connection = new Connection();
        }

        public List<Department> DepartmentList() {
            string query = "SELECT * from departments";
            var data = new List<Department>();
            try
            {
                using (var conenction = _connection.GetConnection())
                {
                    using (var cmd = new MySqlCommand(query, conenction))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                data.Add(new Department() {
                                    Id = Convert.ToInt32(reader["id"].ToString()),
                                    DepartmentNames = reader["department_name"].ToString()
                                });

                                
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                
                throw new ArgumentException(ex.Message);
            }
            return data;
        }
    }
}
