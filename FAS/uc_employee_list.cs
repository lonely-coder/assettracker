using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FAS
{
    public partial class employee_list_controller : UserControl
    {

        //variables
        DataTable _employeesDT = new DataTable();
        DataTable _departmentsDT = new DataTable();
        DataTable _positionsDT = new DataTable();
        int _employee_id;
        int _asset_id;
        string _action;
        int _user_id;
        int _privilege_id;
        //classes
        Employees employee = new Employees();
        Position position = new Position();
        Departments department = new Departments();
        Logs log;
        //forms
        frm_employees _employees;
       
        employee_assets_controller _transfer_assets;
        public employee_list_controller()
        {
            InitializeComponent();
        }
        public employee_list_controller(int UserId)
        {
            InitializeComponent();
            this.btn_add.Text = "New Employee";
            this._user_id = UserId;
            Users user = new Users();

            user.Id = this._user_id;
            this._privilege_id = user.SelectUser();            
        }
        
        public void EmployeeList()
        {
            try {
                dg_employees.Columns.Clear();
                dg_employees.DataSource = null;
                var source = new BindingSource();
                EmployeeRepository employeeRepository= new EmployeeRepository();
                List<Employee> list = employeeRepository.selectAll(txt_filter.Text);
                source.DataSource = list;
                dg_employees.DataSource = source;
                dg_employees.Columns["ID"].Visible = false;
                dg_employees.Columns["Department"].Visible = false;

                AddButtonOnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AddButtonOnGrid() {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dg_employees.Columns.Add(btn);
            btn.HeaderText = "Action";
            btn.Text = "Select";
            btn.UseColumnTextForButtonValue = true;
            btn.Name = "btn";
            btn.Width = 100;
            dg_employees.ClearSelection();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            if (this._privilege_id > 2) {
                this.btn_add.Visible = false;
            }
        }

        private void txt_filter_TextChanged(object sender, EventArgs e)
        {
           if (_employeesDT.Rows.Count > 0) {
           
                   (dg_employees.DataSource as DataTable).DefaultView.RowFilter = "`Employee ID` +`Name` LIKE '%"+ txt_filter.Text.Replace("'", "''") + "%'";
           
           }
            
        }

        private void dg_employees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var empId = int.Parse(dg_employees.CurrentRow.Cells["ID"].Value.ToString());
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                switch (this._action) {
                    case "CREATE_EMPLOYEE_ASSET":
                        
                        break;
                    case "TRANSFER_EMPLOYEE_ASSETS":
                        var _empId = dg_employees.CurrentRow.Cells["pkEmpId"].Value.ToString();
                        DialogResult result = MessageBox.Show("Transfer Assets?", "Confirmation", MessageBoxButtons.YesNo);
                        switch (result)
                        {
                            case DialogResult.Yes:
                                try
                                {
                                    MessageBox.Show("Item Successfully Transfered");
                                    this._employees.Close();
                                    this._transfer_assets._employeeId = int.Parse(_empId);
                                    this._transfer_assets.EmployeeAssets();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);

                                }
                                break;
                            default:
                                this._employees.Close();
                                break;
                        }

                        break;
                    case "RE_ASSIGN_ASSET":
                        var _empId2 = dg_employees.CurrentRow.Cells["pkEmpId"].Value.ToString();
                        var _name = dg_employees.CurrentRow.Cells["Name"].Value.ToString();
                        DialogResult result2 = MessageBox.Show($"Re - Assign Item to {_name}?", "Confirmation", MessageBoxButtons.YesNo);
                        switch (result2)
                        {
                            case DialogResult.Yes:
                                //Accountability accountability = new Accountability();
                                //accountability.ID = this._asset_id;
                                //accountability.EmployeeId = int.Parse(_empId2);
                                //accountability.ReAssignItem();
                                MessageBox.Show("Item Successfully Transfered");
                                break;
                            default:
                                
                                break;
                        }
                        break;
                    default:
                        frm_employee_info _frmEmployeeInfo = new frm_employee_info(this, empId,this._user_id);
                        _frmEmployeeInfo.ShowDialog();
                        break;

                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (btn_add.Text)
            {
                case "Close":
                    this._employees.Close();
                    break;
                default:
                    frm_employee_info _new_employee = new frm_employee_info(this,this._user_id);
                    _new_employee.ShowDialog();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_filter.Text.Length == 0)
            {
                MessageBox.Show("Not found");
            }
            else {
                EmployeeList();
            }
        }
    }
}
