using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace FAS
{
    class EmployeeRepository:IDatabase
    {
        Connection _connection;
        Employee _employee;
        public EmployeeRepository() {
            _connection = new Connection();
        }
        public EmployeeRepository(Employee employee)
        {
            _connection = new Connection();
            _employee = employee;
        }
        public bool EmployeeExist(int id,string employee_id) {
            bool matched = false;

            string query = @"SELECT COUNT(*) 
                            FROM employees 
                            WHERE
                            employee_id = @employee_id 
                            AND id != @id";

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
            string query = @"SELECT employees.id as `Employee Id`,
                            employees.first_name as `First Name`,
                            employees.last_name as `Last Name`,
                            employees.employee_id as `Company Id`,
                            departments.id as `Dept Id`,
                            departments.department_name as `Dept Name`,
                            positions.id as `Pos Id`,
                            positions.position_name as `Pos Name`,
                            employees.date_hired as `Date Hired`
                            FROM 
                            positions INNER JOIN(
                            departments INNER JOIN 
                            employees 
                            ON employees.department_id = departments.id)
                            ON employees.position_id = positions.id 
                            WHERE employees.id = @id LIMIT 1";

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
                                employee.ID = int.Parse(reader["Employee Id"].ToString());
                                employee.EmployeeID = reader["Company Id"].ToString();
                                employee.FirstName = reader["First Name"].ToString();
                                employee.LastName = reader["Last Name"].ToString();
                                employee.Department = new Department() {
                                    Id = int.Parse(reader["Dept Id"].ToString()),
                                    DepartmentNames = reader["Dept Name"].ToString()
                                    
                                };
                                employee.Position = new Position() {
                                    Id = int.Parse(reader["Pos Id"].ToString()),
                                    PositionName = reader["Pos Name"].ToString()

                                };
                                employee.DateHired = Convert.ToDateTime(reader["Date Hired"].ToString());

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
        public Employee SelectByCompanyId(string param)
        {

            Employee employee = new Employee();
            string query = @"SELECT employees.id as `Employee Id`,
                            employees.first_name as `First Name`,
                            employees.last_name as `Last Name`,
                            employees.employee_id as `Company Id`,
                            departments.id as `Dept Id`,
                            departments.department_name as `Dept Name`,
                            positions.id as `Pos Id`,
                            positions.position_name as `Pos Name`,
                            employees.date_hired as `Date Hired`
                            FROM
                            positions INNER JOIN(
                            departments INNER JOIN
                            employees
                            ON employees.department_id = departments.id)
                            ON employees.position_id = positions.id
                            WHERE employees.employee_id = @company_id LIMIT 1";

            try
            {
                using (MySqlConnection connection = _connection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@company_id", param);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                employee.ID = int.Parse(reader["Employee Id"].ToString());
                                employee.EmployeeID = reader["Company Id"].ToString();
                                employee.FirstName = reader["First Name"].ToString();
                                employee.LastName = reader["Last Name"].ToString();
                                employee.Department = new Department()
                                {
                                    Id = int.Parse(reader["Dept Id"].ToString()),
                                    DepartmentNames = reader["Dept Name"].ToString()
                                };
                                employee.Position = new Position()
                                {
                                    Id = int.Parse(reader["Pos Id"].ToString()),
                                    PositionName = reader["Pos Name"].ToString()

                                };
                                employee.DateHired = Convert.ToDateTime(reader["Date Hired"].ToString());

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
                       employees.first_name as `First Name`,
                       employees.last_name as `Last Name`,
                       positions.position_name as `Position`,
                       employees.date_hired as `Date Hired`
                       FROM positions INNER JOIN(
                       departments INNER JOIN
                       employees 
                       ON employees.department_id = departments.id)
                       ON positions.id = employees.position_id
                       WHERE 
                       CONCAT(employee_id,' ',first_name,' ',last_name) LIKE @param";

            try
            {
                using (MySqlConnection connection = _connection.GetConnection()) {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@param", '%' + param + '%');
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) {
                                employeeList.Add(new Employee() {
                                    ID = int.Parse(reader["pkEmpId"].ToString()),
                                    EmployeeID = reader["Employee Id"].ToString(),
                                    FirstName = reader["First Name"].ToString(),
                                    LastName = reader["Last Name"].ToString(),
                                    Position = new Position() {
                                        PositionName = reader["Position"].ToString()
                                    },
                                    DateHired = Convert.ToDateTime(reader["Date Hired"].ToString())
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
                
                using (MySqlConnection connection = _connection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", _employee.EmployeeID);
                        cmd.Parameters.AddWithValue("@firstName", _employee.FirstName);
                        cmd.Parameters.AddWithValue("@lastName", _employee.LastName);
                        cmd.Parameters.AddWithValue("@departmentId", _employee.Department.Id);
                        cmd.Parameters.AddWithValue("@positionId", _employee.Position.Id);
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

                using (MySqlConnection connection = _connection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", _employee.ID);
                        cmd.Parameters.AddWithValue("@employeeId", _employee.EmployeeID);
                        cmd.Parameters.AddWithValue("@firstName", _employee.FirstName);
                        cmd.Parameters.AddWithValue("@lastName", _employee.LastName);
                        cmd.Parameters.AddWithValue("@departmentId", _employee.Department.Id);
                        cmd.Parameters.AddWithValue("@positionId", _employee.Position.Id);
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
