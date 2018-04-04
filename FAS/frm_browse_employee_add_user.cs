using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FAS
{
    public partial class frm_browse_employee_add_user : MetroFramework.Forms.MetroForm
    {
        frm_add_user _add_user;
    
        Employees employee = new Employees();
        Departments department = new FAS.Departments();
        Position position = new Position();
        Logs log;
        //datatables
        DataTable employeeDT = new DataTable();
        DataTable departmentDT = new DataTable();
        DataTable positionDT = new DataTable();
        public frm_browse_employee_add_user()
        {
            InitializeComponent();
        }
        public frm_browse_employee_add_user(frm_add_user AddUser)
        {
            InitializeComponent();
            this._add_user = AddUser;
        }
        public void Employees()
        {

            employee.parameter = metroTextBox1.Text;
            employeeDT = employee.SelectAllEmployees();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = employeeDT;
            dataGridView1.Columns["pkEmpId"].Visible = false;
            dataGridView1.Columns["Position"].Visible = false;
            //dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[4].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "#";
            btn.Text = "Select";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
            dataGridView1.ClearSelection();
        }
        private void frm_browse_employee_add_user_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try {
                this.Employees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var empId = int.Parse(dataGridView1.CurrentRow.Cells["pkEmpId"].Value.ToString());
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                _add_user.metroTextBox4.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                _add_user._id = int.Parse(empId.ToString());
                this.Close();
            }
            }
    }
}
