﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace FAS
{
    public class AssetsRepository
    {
        Connection _connection;
       
        public AssetsRepository(){
            _connection = new Connection();
        }
        
        public List<AssetsModel> GetEmployeeAssets(int employee_id)
        {
            List<AssetsModel> assetsModelList = new List<AssetsModel>();

            string query = $@"SELECT 
                assets.id as `Asset Id`,
                IFNULL(assets.property_tag,'N/A') as `Property Tag`,
                employees.id as `emp_id`,
                employees.first_name as `First Name`,
                employees.last_name as `Last Name`,
                employees.employee_id as `Employee Id`,
                departments.id as `Dept Id`,
                departments.department_name as `Dept Name`,
                positions.id as `Pos Id`,
                positions.position_name as `Pos Name`,
                items.id as `Item Id`,
                items.model as `Model`,
                IFNULL(item_serials.id,0) as `Item Serial Id`,
                IFNULL(item_serials.serial_number,'N/A') as `Serial Number`,
                assets.asset_price as `Amount`    ,
                assets.date_acquired as `Date Acquired`,
                assets.quantity as `Quantity`
                FROM item_serials RIGHT JOIN(
                items LEFT JOIN(
                positions INNER JOIN(
                departments INNER JOIN(
                employees RIGHT JOIN assets 
                ON employees.id = assets.employee_id) 
                ON departments.id = employees.department_id)
                ON positions.id = employees.position_id)
                ON items.id = assets.item_id)
                ON item_serials.id = assets.serial_id
                WHERE assets.employee_id = @id
                AND assets.remarks IS NULL";

            try
            {
                using (var cmd = new MySqlCommand(query, _connection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", employee_id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            assetsModelList.Add(
                                new AssetsModel()
                                {
                                    Id = int.Parse(reader["Asset Id"].ToString()),
                                    PropertyTag = reader["Property Tag"].ToString(),
                                    //ItemId = int.Parse(reader["Item Id"].ToString()),
                                    Items = new Items()
                                    {
                                        Id = int.Parse(reader["Item Id"].ToString()),
                                        Model = reader["Model"].ToString()
                                    },
                                    //EmployeeId = int.Parse(reader["emp_id"].ToString()),
                                    Employee = new Employee()
                                    {
                                        ID = int.Parse(reader["emp_id"].ToString()),
                                        FirstName = reader["First Name"].ToString(),
                                        LastName = reader["Last Name"].ToString(),
                                        Department = new Department()
                                        {
                                            Id = int.Parse(reader["Dept Id"].ToString()),
                                            DepartmentNames = reader["Dept Name"].ToString()
                                        },
                                        Position = new Position()
                                        {
                                            Id = int.Parse(reader["Pos Id"].ToString()),
                                            PositionName = reader["Pos Name"].ToString()
                                        }
                                    },
                                    Serial = new Serial()
                                    {
                                        Id = int.Parse(reader["Item Serial Id"].ToString()),
                                        SerialNumber = reader["Serial Number"].ToString()
                                    },
                                    Price = Convert.ToDouble(reader["Amount"].ToString()),
                                    Quantity = int.Parse(reader["Quantity"].ToString()),
                                    DateAcquired = Convert.ToDateTime(reader["Date Acquired"].ToString())
                                }
                                );
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }

            return assetsModelList;
        }

        public List<AssetsModel> GetAllEmployeeWithAssets(string employee_name)
        {
            List<AssetsModel> assetsModelList = new List<AssetsModel>();

            string query = $@"SELECT 
                employees.id as `emp_id`,
                employees.first_name as `First Name`,
                employees.last_name as `Last Name`,
                employees.employee_id as `Employee Id`,
                departments.id as `Dept Id`,
                departments.department_name as `Dept Name`,
                positions.id as `Pos Id`,
                positions.position_name as `Pos Name`,
                SUM(assets.quantity) as `Quantity`
                FROM 
                positions INNER JOIN(
                departments INNER JOIN(
                assets INNER JOIN employees 
                ON assets.employee_id = employees.id)
                ON employees.department_id = departments.id)
                ON positions.id = employees.position_id
                WHERE CONCAT(first_name,' ',last_name) LIKE @emp_name
                AND assets.remarks IS NULL
                GROUP BY employees.id";

            try
            {
                using (var cmd = new MySqlCommand(query, _connection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@emp_name", '%' + employee_name + '%');
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            assetsModelList.Add(
                                new AssetsModel()
                                {
                                    EmployeeId = int.Parse(reader["emp_id"].ToString()),
                                    Employee = new Employee()
                                    {
                                        ID = int.Parse(reader["emp_id"].ToString()),
                                        FirstName = reader["First Name"].ToString(),
                                        LastName = reader["Last Name"].ToString(),
                                        Department = new Department()
                                        {
                                            Id = int.Parse(reader["Dept Id"].ToString()),
                                            DepartmentNames = reader["Dept Name"].ToString()
                                        },
                                        Position = new Position()
                                        {
                                            Id = int.Parse(reader["Pos Id"].ToString()),
                                            PositionName = reader["Pos Name"].ToString()
                                        }
                                    },
                                    Quantity =int.Parse(reader["Quantity"].ToString())
                                }
                                );
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }

            return assetsModelList;
        }
        public bool CheckPropertyTagIfAvailable(string property_tag)
        {
            bool property_tag_match_found = false;

            string query = @"SELECT count(*) from assets where property_tag = @property_tag AND property_tag != ''";

            using (var connection = _connection.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("property_tag", property_tag);
                    property_tag_match_found = (Convert.ToInt32(cmd.ExecuteScalar()) > 0);
                }

            }
            return property_tag_match_found;
        }

    }
}
