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
    public partial class frm_item_per_model : Form
    {
        int _id;
        public frm_item_per_model(int id)
        {
            InitializeComponent();
            this._id = id;
        }

        private void frm_item_per_model_Load(object sender, EventArgs e)
        {
            ItemList1.Refresh();
            ItemList1.SetParameterValue("item_id", this._id);
            crystalReportViewer1.ReportSource=ItemList1;

        }
    }
}
