using System;
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
            DepartmentsRepository department = new DepartmentsRepository();

            var list = department.DepartmentList();
            var source = new BindingSource();
            list.Insert(0, new Department() { DepartmentNames = "-Select-" });
            source.DataSource = list;
            metroComboBox1.ValueMember = "Id";
            metroComboBox1.DisplayMember = "DepartmentNames";
            metroComboBox1.DataSource = source;

            metroComboBox1.SelectedIndex = 0;
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
