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
    public partial class uc_vendor_list : UserControl
    {
        Logs log;
        public uc_vendor_list()
        {
            InitializeComponent();
        }
        public void Vendors() {
            try {
                Vendors vendors = new Vendors();
                vendors.Parameter = metroTextBox1.Text;
                DataTable dt = vendors.SelectVendor();

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "#";
                btn.Text = "View";
                btn.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(btn);
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uc_vendor_list_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Vendors();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dataGridView1.CurrentRow.Cells["pkVendorID"].Value.ToString());
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                frm_add_vendors _vendors = new frm_add_vendors(this, id);
                _vendors.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_add_vendors _vendors = new frm_add_vendors(this);
            _vendors.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_add_vendors _vendors = new frm_add_vendors(this);
            _vendors.ShowDialog();
        }
    }
}
