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
    public partial class frm_print_per_department : Form
    {
        int _department_id;
        public frm_print_per_department()
        {
            InitializeComponent();
        }
        public frm_print_per_department(int department)
        {
            
            InitializeComponent();
            _department_id = department;
        }

        private void frm_print_per_department_Load(object sender, EventArgs e)
        {
            DepartmentAssets1.Refresh();
            DepartmentAssets1.SetParameterValue("department_id", _department_id);
            
            crystalReportViewer1.ReportSource = DepartmentAssets1;
        }
    }
}
