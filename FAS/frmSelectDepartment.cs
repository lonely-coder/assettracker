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
            DepartmentsRepository departmentsRepository = new DepartmentsRepository();

            var list = departmentsRepository.DepartmentList();
            var source = new BindingSource();
            list.Insert(0,new Department() { DepartmentNames = "-Select-"});
            source.DataSource = list;
            metroComboBox1.ValueMember = "Id";
            metroComboBox1.DisplayMember = "DepartmentNames";
            metroComboBox1.DataSource = source;

            metroComboBox1.SelectedIndex = 0;
        }
        private void frmSelectDepartment_Load(object sender, EventArgs e)
        {
            this.Departments();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
