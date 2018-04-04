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
    public partial class frm_preview_vendors : Form
    {
        public frm_preview_vendors()
        {
            InitializeComponent();
        }

        private void frm_preview_vendors_Load(object sender, EventArgs e)
        {
            VendorList1.SetDatabaseLogon("fas_user", "d34thn0te");
            VendorList1.Refresh();
        }
    }
}
