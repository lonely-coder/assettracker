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
    public partial class frm_test : Form
    {
        public frm_test()
        {
            InitializeComponent();
        }

        private void frm_test_Load(object sender, EventArgs e)
        {
            DataTable Items = new DataTable();

            Items.Columns.Add("Category",typeof(string));
        }
    }
}
