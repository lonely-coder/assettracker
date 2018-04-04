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
    public partial class frmSelectDepartment : MetroFramework.Forms.MetroForm
    {
        public frmSelectDepartment()
        {
            InitializeComponent();
        }
        private void Departments() {
            Departments department = new Departments();

            DataTable _dt = department.LoadDepartments();
            metroComboBox1.DisplayMember = _dt.Columns["department_name"].ToString();
            metroComboBox1.ValueMember = _dt.Columns["id"].ToString();
            metroComboBox1.DataSource = _dt;

            DataRow row = _dt.NewRow();
            row["department_name"] = "Select A Department";
            row["id"] = 0;

            _dt.Rows.InsertAt(row, 0);
            metroComboBox1.SelectedIndex = 0;
        }
        private void frmSelectDepartment_Load(object sender, EventArgs e)
        {
            this.Departments();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_print_per_department _print = new frm_print_per_department(int.Parse(metroComboBox1.SelectedValue.ToString()));
            _print.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
