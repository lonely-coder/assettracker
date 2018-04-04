using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAS
{
    class Employee
    {
        private int _id;
        private string _employee_id;
        private string _first_name;
        private string _last_name;
        private int _department_id;
        private int _position_id;
        private DateTime _date_hired;

        public int ID
        {
            get { return this._id; }
            set
            {
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
                return this._employee_id;
            }
            set
            {

                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._employee_id = value;
                }
                else {

                    throw new ArgumentException("Employee ID is Required");
                }

            }//end setter
        }

        public string FirstName
        {
            get
            {
                return this._first_name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._first_name = value;
                }
                else {
                    throw new ArgumentException("First Name is Required");
                }

            }
        }
        public string LastName
        {
            get
            {
                return this._last_name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._last_name = value;
                }
                else
                {
                    throw new ArgumentException("Last Name is Required");
                }
            }
        }
        public int DepartmentId
        {
            get
            {
                return this._department_id;
            }
            set
            {
                if (value > 0)
                {
                    this._department_id = value;
                }
                else
                {
                    throw new ArgumentException("Department is Required");
                }
            }
        }
        public int PositionId
        {
            get
            {
                return this._position_id;
            }
            set
            {
                if (value > 0)
                {
                    this._position_id = value;
                }
                else
                {
                    throw new ArgumentException("Position is Required");
                }
            }
        }

        public DateTime DateHired
        {
            get
            {
                return this._date_hired;
            }
            set
            {
                
                    this._date_hired = value;
            }
        }
    }
}
