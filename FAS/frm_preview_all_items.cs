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
    public partial class frm_preview_all_items : Form
    {
        int _item_id;
        public frm_preview_all_items()
        {
            InitializeComponent();
        }
        public frm_preview_all_items(int ItemId) {
            InitializeComponent();
            this._item_id = ItemId;
        }

        private void frm_preview_all_items_Load(object sender, EventArgs e)
        {
            //CrystalReport11.SetDatabaseLogon("fas_user", "d34thn0te");
            //CrystalReport11.SetParameterValue("item_id", this._item_id);
            CrystalReport11.Refresh();
            crystalReportViewer1.ReportSource = CrystalReport11;
        }
    }
}
