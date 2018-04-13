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
        int _user_id;
        int _privilege_id;
        
        public employee_list_controller(int UserId)
        {
            InitializeComponent();
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
            
        }

        private void dg_employees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var emp_id = int.Parse(dg_employees.CurrentRow.Cells["ID"].Value.ToString());

            frm_employee_info _frmEmployeeInfo = new frm_employee_info(this, emp_id, this._user_id);
            _frmEmployeeInfo.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
                EmployeeList();   
        }
        private void txt_filter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                EmployeeList();
            }
        }
    }
}
