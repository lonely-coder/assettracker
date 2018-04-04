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
    public partial class frm_preview_scrap : Form
    {
        int _id;
        public frm_preview_scrap()
        {
            InitializeComponent();
        }
        public frm_preview_scrap(int id)
        {
            InitializeComponent();
            this._id = id;
        }

        private void frm_preview_scrap_Load(object sender, EventArgs e)
        {
            DamageItems1.Refresh();
            DamageItems1.SetParameterValue("department_id",this._id);
            crystalReportViewer1.ReportSource = DamageItems1;
        }
    }
}
