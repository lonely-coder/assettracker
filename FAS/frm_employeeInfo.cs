using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace FAS
{
    public partial class frm_employeeInfo : MetroFramework.Forms.MetroForm
    {
        int _employeeId;
        int _user_id;
        int _privilege_id;
        string [] gender = new string[] {"Select Gender", "Male","Female"};

        employee_list_controller _employee;
        Employees employee = new Employees();
        Logs log;
        public frm_employeeInfo()
        {
            InitializeComponent();
  
        }
        public frm_employeeInfo(employee_list_controller employee, int UserId)
        {
            InitializeComponent();
            this._employee = employee;
            this._user_id = UserId;

        }
        public frm_employeeInfo(employee_list_controller employee, int id,int UserId)
        {
            InitializeComponent();
            this._employeeId = id;
            this._employee = employee;
            this._user_id = UserId;
            Users user = new Users();
            user.Id = this._user_id;
            this._privilege_id = user.SelectUser();

        }
        public void ClearFields()
        {
            txt_empid.Clear();
            txt_empid.Focus();
            txt_firstName.Clear();
            txt_lastName.Clear();
            
            cb_department.SelectedIndex = 0;
            cb_position.SelectedIndex = 0;
            
        }

        public bool verifyExisting(String employeeId)
        {

            String empId = employeeId;
            employee.Query = string.Format(@"SELECT employee_id FROM employees WHERE employee_id = '{0}' AND id !='{1}'", empId, this._employeeId);

            DataTable empDT = employee.Select();

            return (empDT.Rows.Count > 0);

        }
        //private void LoadGender()
        //{
        //    try
        //    {

        //        for (int i = 0; i < 3; i++) {
        //            cb_gender.Items.Add(gender[i]);
        //        }
        //        cb_gender.SelectedIndex = 0;
                
        //    //    employee.Query = "SELECT * FROM gender";

        //    //    DataTable genderDataTable = employee.Select();

        //    //    cb_gender.DisplayMember = genderDataTable.Columns[1].ToString();

        //    //    cb_gender.ValueMember = genderDataTable.Columns[0].ToString();

        //    //    cb_gender.DataSource = genderDataTable;

        //    //    DataRow genderdr = genderDataTable.NewRow();

        //    //    genderdr["gender"] = "Select a Gender";
        //    //    genderdr["id"] = 0;

        //    //    genderDataTable.Rows.InsertAt(genderdr, 0);
        //    }
        //    catch (Exception ex) {

        //    }
            
        //}
        private void LoadDepartment()
        {
            try
            {
                employee.Query = @"SELECT * FROM departments";

                DataTable departmentsDataTable = employee.Select();

                cb_department.DisplayMember = departmentsDataTable.Columns[1].ToString();

                cb_department.ValueMember = departmentsDataTable.Columns[0].ToString();

                cb_department.DataSource = departmentsDataTable;

                DataRow dr = departmentsDataTable.NewRow();

                dr["department_name"] = "Select a Department";
                dr["id"] = 0;

                departmentsDataTable.Rows.InsertAt(dr, 0);
            }
            catch (Exception ex) {

            }
            

        }
        //private void LoadEmploymentStatus()
        //{
        //    try {
        //        employee.Query = @"SELECT * FROM employment_status";

        //        DataTable employmentStatDataTable = employee.Select();

        //        cb_employmentStatus.DisplayMember = employmentStatDataTable.Columns[1].ToString();

        //        cb_employmentStatus.ValueMember = employmentStatDataTable.Columns[0].ToString();

        //        cb_employmentStatus.DataSource = employmentStatDataTable;

        //        DataRow employmentStatdr = employmentStatDataTable.NewRow();

        //        employmentStatdr["employment_status"] = "Select Employment Status";
        //        employmentStatdr["id"] = 0;

        //        employmentStatDataTable.Rows.InsertAt(employmentStatdr, 0);
        //    }
        //    catch (Exception ex) {

        //    }
            

        //}
        private void LoadPosition(int Param)
        {
            try {
                employee.Query = String.Format(@"SELECT * FROM positions
                                           WHERE department_id = {0}",
                                           Param);

                DataTable positionDataTable = employee.Select();

                cb_position.DisplayMember = positionDataTable.Columns[2].ToString();

                cb_position.ValueMember = positionDataTable.Columns[0].ToString();

                cb_position.DataSource = positionDataTable;

                DataRow positiondr = positionDataTable.NewRow();

                positiondr["position_name"] = "Select a Position";
                positiondr["id"] = 0;

                positionDataTable.Rows.InsertAt(positiondr, 0);

                cb_position.SelectedIndex = 0;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (this._privilege_id > 2) {
                cb_department.Enabled = false;
                cb_position.Enabled = false;
                txt_empid.Enabled = false;
                txt_firstName.Enabled = false;
                txt_lastName.Enabled = false;
                //cb_gender.Enabled = false;
                //cb_employmentStatus.Enabled = false;
                dateTimePicker1.Enabled = false;
                btn_save.Enabled = false;
            }

            //this.LoadGender();

            this.LoadDepartment();

            //this.LoadEmploymentStatus();

            if (this._employeeId > 0)
            {
                //employee.Query = $@"SELECT * FROM employees WHERE employees.id = {this._employeeId}";

                //DataTable employeeDT = employee.Select();
                employee.ID = this._employeeId;
                DataTable employeeDT = employee.SelectEmployeePerId();
                foreach (DataRow row in employeeDT.Rows)
                {
                    txt_empid.Text = row["employee_id"].ToString();
                    cb_department.SelectedValue = row["department_id"].ToString();
                    cb_position.SelectedValue = row["position_id"].ToString();
                    //cb_gender.SelectedIndex = int.Parse(row["gender_id"].ToString())+1;
                    txt_firstName.Text = row["first_name"].ToString();
                    txt_lastName.Text = row["last_name"].ToString();
                    //cb_employmentStatus.SelectedValue = row["employment_status_id"].ToString();

                }

            }
            else
            {

                cb_department.SelectedIndex = 0;
                //cb_gender.SelectedIndex = 0;
                //cb_employmentStatus.SelectedIndex = 0;
                btn_save.Text = "Save";
            }

        }



        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                employee.FirstName = this.txt_firstName.Text;
                employee.LastName = this.txt_lastName.Text;
                employee.EmployeeID = this.txt_empid.Text;
                //employee.GenderId = int.Parse(this.cb_gender.SelectedIndex.ToString());
                employee.DepartmentId = int.Parse(this.cb_department.SelectedValue.ToString());
                employee.PositionId = int.Parse(this.cb_position.SelectedValue.ToString());
                employee.DateHired = this.dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm");
                //employee.EmploymentStatusId = int.Parse(this.cb_employmentStatus.SelectedValue.ToString());
                switch (this._employeeId)
                {
                    case 0:
                        employee.CreateEmployee();
                        MessageBox.Show("Records has been saved!");
                        
                        break;
                    default:
                        employee.ID = this._employeeId;
                        employee.UpdateEmployee();
                        MessageBox.Show("Records has been Updated!");
                        break;
                }
                this.ClearFields();
                if (_employee != null) {
                    _employee.EmployeeList();
                }
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_cancel_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txt_empid_Leave_1(object sender, EventArgs e)
        {
            if (this.verifyExisting(txt_empid.Text).Equals(true))
            {
                MessageBox.Show("Employee Id already exists");
                txt_empid.Text = "";
                txt_empid.Focus();
            }
        }

        private void cb_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadPosition(int.Parse(cb_department.SelectedValue.ToString()));
        }
    }
}
