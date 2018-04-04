using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FAS
{
    public partial class uc_report_assets : UserControl
    {
        Asset asset = new Asset();
        public uc_report_assets()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //frm_preview_assets _print = new frm_preview_assets();
            //_print.ShowDialog();
        }


        private void uc_report_assets_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                asset.parameter = metroTextBox1.Text;
                DataTable dt = asset.SelectAllEmployeeAssets();

                metroGrid1.DataSource = dt;
                metroGrid1.ClearSelection();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
