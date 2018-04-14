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
    public partial class frm_select_dept_scrapt : MetroFramework.Forms.MetroForm
    {
        public frm_select_dept_scrapt()
        {
            InitializeComponent();
        }

        private void frm_select_dept_scrapt_Load(object sender, EventArgs e)
        {
            DepartmentsRepository departmentsRepositor = new DepartmentsRepository();

            //var _dt = department.DepartmentList();

            ////DataRow row = _dt.NewRow();
            //row["department_name"] = "Select Department";
            //row["id"] = 0;

            //_dt.Rows.InsertAt(row, 0);

            //metroComboBox1.DisplayMember = _dt.Columns[1].ToString();
            //metroComboBox1.ValueMember = _dt.Columns[0].ToString();
            //metroComboBox1.DataSource = _dt;

            //metroComboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
