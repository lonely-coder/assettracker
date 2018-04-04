using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace FAS
{
    class Employees : DB
    {
        private int _id;
        private string _employeeId;
        private string _firstName;
        private string _lastName;
        private int _departmentId;
        private int _positionId;
        private int _genderId;
        private int _employmentStatusId;
        private string _dateHired;
        private string _endOfContract;
        private string _parameter;
        private DataTable _dt;

        Logs log = new Logs();
        public int ID {
            get { return this._id; }
            set {
                if (value > 0)
                {
                    this._id = value;
                }
                else {
                    throw new ArgumentException("Please select an employee");
                }
            }
        }
        public string EmployeeID
        {
            get
            {
                return this._employeeId;
            }
            set
            {

                if (!String.IsNullOrWhiteSpace(value))
                {
                    this._employeeId = value;
                }
                else {
                    
                    throw new ArgumentException("Employee ID is Required");
                }

            }//end setter
        }

        public string FirstName {
            get
            {
                return this._firstName;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this._firstName = value;
                }
                else {
                    throw new ArgumentException("First Name is Required");
                }
                
            }
        }
        public string LastName {
            get
            {
                return this._lastName;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this._lastName = value;
                }
                else
                {
                    throw new ArgumentException("Last Name is Required");
                }
            }
        }
        public int DepartmentId {
            get
            {
                return this._departmentId;
            }
            set
            {
                if (value > 0)
                {
                    this._departmentId = value;
                }
                else
                {
                    throw new ArgumentException("Department is Required");
                }
            }
        }
        public int PositionId {
            get
            {
                return this._positionId;
            }
            set
            {
                if (value > 0)
                {
                    this._positionId = value;
                }
                else
                {
                    throw new ArgumentException("Position is Required");
                }
            }
        }

        public string DateHired {
            get
            {
                return this._dateHired;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this._dateHired = value;
                }
                else
                {
                    throw new ArgumentException("Date Hired is Required");
                }
            }
        }
        public string EndOfContractDate {
            get
            {
                return this._endOfContract;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _endOfContract = value;
                }
                else
                {
                    throw new ArgumentException("Last Name is Required");
                }
            }
        }
        public string parameter
        {
            get { return this._parameter; }
            set { this._parameter = value; }
        }

      
        
        public void UpdateEmployee() {
            try {
                

                if (this.OpenConnection() == true) {
                    cmd = new MySqlCommand(this.Query, this.connection);
                    
                    cmd.Parameters.AddWithValue("@firstName", this._firstName);
                    cmd.Parameters.AddWithValue("@lastName", this._lastName);
                    cmd.Parameters.AddWithValue("@departmentId", this._departmentId);
                    cmd.Parameters.AddWithValue("@positionId", this._positionId);
                    cmd.Parameters.AddWithValue("@dateHired", this._dateHired);
                    cmd.Parameters.AddWithValue("@id", this._id);
                    cmd.ExecuteNonQuery();

                    this.CloseConnection();
                }
            }
            catch (MySqlException ex) {
                log.ErrorLog(ex.Message, this);
                throw new ArgumentException("An error occured while updating employee record.\nPlease contact your System Administrator");
            }
            
        }
        public DataTable SelectAllEmployees() {

            try {
                    this.Query = $@"SELECT
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
                       CONCAT(employees.first_name,employees.last_name,employees.employee_id)
                       LIKE @parameter";

                        if (this.OpenConnection() == true)
                        {
                            cmd = new MySqlCommand(this.Query, this.connection);
                            da = new MySqlDataAdapter(cmd);
                            _dt = new DataTable();
                            cmd.Parameters.AddWithValue("@parameter", "%" + this._parameter + "%");
                            cmd.Prepare();
                            da.SelectCommand = cmd;
                            da.Fill(_dt);
                            this.CloseConnection();
                        }
                }
                catch (MySqlException ex) {
                    log.ErrorLog(ex.Message, this);
                    throw new ArgumentException("Error loading employee list.\nPlease contact your System Administrator");
                }
            return this._dt;   
        }
      
        public DataTable SelectMatchedEmployeeCompanyId() {

            this._dt = new DataTable();

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

            try {
                if (this.OpenConnection()) {
                    using (var cmd = new MySqlCommand(query,connection) ) {
                        cmd.Parameters.AddWithValue("@employee_id",'%'+this._parameter+'%');
                        using (var reader = cmd.ExecuteReader()) {
                            this._dt.Load(reader);
                        }
                    }

                    this.CloseConnection();
                }
            }
            catch (Exception ex) {

                throw new ArgumentException(ex.ToString());
            }
            return this._dt;
        }
        public DataTable SelectEmployeeCompanyId()
        {

            this._dt = new DataTable();

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
                       employee_id = @employee_id";

            try
            {
                if (this.OpenConnection())
                {
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@employee_id",this._parameter);
                        using (var reader = cmd.ExecuteReader())
                        {
                            this._dt.Load(reader);
                        }
                    }

                    this.CloseConnection();
                }
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
            return this._dt;
        }
    }
}
