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
    public partial class frm_department_picker : MetroFramework.Forms.MetroForm
    {
        public frm_department_picker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Departments department = new Departments();

            DataTable _dt = department.LoadDepartments();
            metroComboBox1.DisplayMember = _dt.Columns["department_name"].ToString();
            metroComboBox1.ValueMember= _dt.Columns["id"].ToString();
            metroComboBox1.DataSource = _dt;

            DataRow row = _dt.NewRow();
            row["department_name"] = "Select A Department";
            row["id"] = 0;

            _dt.Rows.InsertAt(row,0);
            metroComboBox1.SelectedIndex = 0;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var deptId =int.Parse(metroComboBox1.SelectedValue.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var deptId = int.Parse(metroComboBox1.SelectedValue.ToString());
            frm_preview_employees _print = new frm_preview_employees(deptId);
            _print.Show();
        }
    }
}
