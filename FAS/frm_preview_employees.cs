using System;
using System.Windows.Forms;

namespace FAS
{
    public partial class frm_preview_employees : Form
    {
        int _department_id;
        public frm_preview_employees()
        {
            InitializeComponent();
        }
        public frm_preview_employees(int DepartmentId)
        {
            InitializeComponent();
            _department_id = DepartmentId;
        }

        private void frm_preview_employees_Load(object sender, EventArgs e)
        {

            Employeerpt1.Refresh();
            Employeerpt1.SetParameterValue("department_id",_department_id);
            crystalReportViewer1.ReportSource = Employeerpt1;
        }
    }
}
