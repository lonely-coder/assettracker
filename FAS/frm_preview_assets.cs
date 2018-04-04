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
    public partial class frm_preview_assets : Form
    {
        int _employee_id;
        public frm_preview_assets()
        {
            InitializeComponent();
        }
        public frm_preview_assets(int EmployeeId)
        {
            InitializeComponent();
            _employee_id = EmployeeId;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            EmployeeAssets1.Refresh();
            EmployeeAssets1.SetDatabaseLogon("fas_user", "d34thn0te");
            EmployeeAssets1.SetParameterValue("employee_id",this._employee_id);
            crystalReportViewer1.ReportSource = EmployeeAssets1;
        }
    }
}
