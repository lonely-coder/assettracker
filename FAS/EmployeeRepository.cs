using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace FAS
{
    class EmployeeRepository:IDatabase
    {
        Connection _connection;
        Employee _employee;
        public EmployeeRepository(Connection connection) {
            _connection = connection;
        }
        public EmployeeRepository(Connection connection,Employee employee)
        {
            _connection = connection;
            _employee = employee;
        }
        public bool EmployeeExist(int id,string employee_id) {
            bool matched = false;

            string query = "SELECT COUNT(*) FROM employees WHERE employee_id = @employee_id AND id != @id";
            try
            {
                using (MySqlConnection connection = _connection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@employee_id",employee_id);
                        cmd.Parameters.AddWithValue("@id", id);
                        matched = int.Parse(cmd.ExecuteScalar().ToString()) > 0;
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
                throw;
            }

                return matched;
        }
        public Employee SelectById(int id) {

            Employee employee = new Employee();
            string query = "SELECT * FROM employees WHERE id = @id LIMIT 1";

            try
            {
                using (MySqlConnection connection = _connection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                employee.ID = int.Parse(reader["id"].ToString());
                                employee.EmployeeID = reader["employee_id"].ToString();
                                employee.FirstName = reader["first_name"].ToString();
                                employee.LastName = reader["last_name"].ToString();
                                employee.DepartmentId = int.Parse(reader["department_id"].ToString());
                                employee.PositionId = int.Parse(reader["position_id"].ToString());
                                employee.DateHired = Convert.ToDateTime(reader["date_hired"].ToString());

                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return employee;
        }
        public List<Employee> selectAll(string param)
        {
            List<Employee> employeeList = new List<Employee>();
            string query = $@"SELECT
                       employees.id as `pkEmpId`,
                       employees.employee_id as `Employee ID`,
                       departments.department_name as `Department`,
                       CONCAT(employees.first_name,' ',employees.last_name) AS `Name`,
                       positions.position_name as `Position`
                       FROM positions INNER JOIN(
                       departments INNER JOIN
                       employees 
                       ON employees.department_id = departments.id)
                       ON positions.id = employees.position_id
                       WHERE 
                       employee_id LIKE @employee_id";

            try
            {
                using (MySqlConnection connection = _connection.GetConnection()) {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@employee_id", '%' + param + '%');
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) {
                                employeeList.Add(new Employee() {
                                    ID = int.Parse(reader["pkEmpId"].ToString()),
                                    EmployeeID = reader["Employee Id"].ToString(),
                                    FirstName = reader["First Name"].ToString(),
                                    LastName = reader["Last Name"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
            return employeeList;
        }
        public bool Insert() {
            string query = $@"INSERT INTO employees (
                    `employee_id`,
                    `first_name`,
                    `last_name`,
                    `department_id`,
                    `position_id`,
                    `date_hired`,
                    `date_created`) VALUES (
                    @employeeId,
                    @firstName,
                    @lastName,
                    @departmentId,
                    @positionId,
                    @dateHired,
                    NOW())";
            try
            {
                
                Employee employee = new Employee();
                Console.WriteLine(employee.PositionId);
                using (MySqlConnection connection = _connection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", _employee.EmployeeID);
                        cmd.Parameters.AddWithValue("@firstName", _employee.FirstName);
                        cmd.Parameters.AddWithValue("@lastName", _employee.LastName);
                        cmd.Parameters.AddWithValue("@departmentId", _employee.DepartmentId);
                        cmd.Parameters.AddWithValue("@positionId", _employee.PositionId);
                        cmd.Parameters.AddWithValue("@dateHired", _employee.DateHired);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                   
            }
            catch (MySqlException ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        
        public bool Update()
        {
            string query = $@"UPDATE employees SET
                       `employee_id` = @employeeId,
                       `department_id` = @departmentId,
                       `position_id` = @positionId,
                       `first_name` = @firstName,
                       `last_name` = @lastName,
                       `date_updated` = NOW()
                        WHERE id = @id";
            try
            {

                Employee employee = new Employee();
                Console.WriteLine(employee.PositionId);
                using (MySqlConnection connection = _connection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", _employee.ID);
                        cmd.Parameters.AddWithValue("@employeeId", _employee.EmployeeID);
                        cmd.Parameters.AddWithValue("@firstName", _employee.FirstName);
                        cmd.Parameters.AddWithValue("@lastName", _employee.LastName);
                        cmd.Parameters.AddWithValue("@departmentId", _employee.DepartmentId);
                        cmd.Parameters.AddWithValue("@positionId", _employee.PositionId);
                        cmd.Parameters.AddWithValue("@dateHired", _employee.DateHired);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }

            }
            catch (MySqlException ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }
    }
}
