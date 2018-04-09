using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
namespace FAS
{
    public class Departments
    {
        private int _id;
        private string _department;
        private DataTable _dt;
        Connection _connection;
        public Departments() {
            _connection = new Connection();
        }

        Logs log = new Logs();
        public int Id {
            get { return this._id; }
            set
            {
                if (value > 0)
                {
                    this._id = value;
                }
                else
                {
                    throw new ArgumentException("Department ID is Empty");
                }
            }
        }
        public string Department {
            get { return this._department; }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._department = value;
                }
                else {
                    throw new ArgumentException("Please provide a Department Name");
                }
            }
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
                log.ErrorLog(ex.Message, this);
                throw new ArgumentException("Error loading categories.\nPlease contact your System Administrator.");
            }
            return data;
        }
    }
}
