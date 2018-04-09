using System;
using System.Windows.Forms;

namespace FAS
{
    public partial class uc_vendor_list : UserControl
    {
        public uc_vendor_list()
        {
            InitializeComponent();
        }
        public void Vendors() {
            try {
                VendorRepository vendorRepository = new VendorRepository();
                var list = vendorRepository.getVendorByEntity(metroTextBox1.Text);
                
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = list;
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
            var id = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
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
