using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
namespace FAS
{
    public class Departments:DB
    {
        private int _id;
        private string _department;
        private DataTable _dt;

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
        public DataTable LoadDepartments() {
            
            try
            {
                this.Query = "SELECT * from departments";
                this._dt = new DataTable();
                this._dt = this.Select();

            }
            catch (MySqlException ex)
            {
                log.ErrorLog(ex.Message, this);
                throw new ArgumentException("Error loading categories.\nPlease contact your System Administrator.");
            }
            return _dt;
        }
    }
}
