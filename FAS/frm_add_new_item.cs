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
    public partial class frm_add_new_item : Form
    {
        private DataTable _dt;
        public frm_add_new_item()
        {
            InitializeComponent();
        }
        private void GetVendors() {
            Vendors vendorObj = new Vendors();

            this._dt = vendorObj.SelectAllVendords();

            DataRow row = this._dt.NewRow();
            row[0] = 0;
            row[1] = "Select Vendor";
            this._dt.Rows.InsertAt(row,0);
            this.metroComboBox1.DisplayMember = this._dt.Columns[1].ToString();
            this.metroComboBox1.ValueMember = this._dt.Columns[0].ToString();
            this.metroComboBox1.DataSource = this._dt;

            this.metroComboBox1.SelectedIndex = 0;
        }
        private void frm_add_new_item_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Insert(0,"null", "null", "null", "null", "null","0.00","null");
            this.dataGridView1.ClearSelection();

            this.GetVendors();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                frm_item_lookup _item_list = new frm_item_lookup(this);
                _item_list.ShowDialog();
            } else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn && e.RowIndex >= 0) {
                
            }
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    hitTestInfo = dataGridView1.HitTest(e.X, e.Y);
            //    if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
            //        dataGridView1.BeginEdit(true);
            //    else
            //        dataGridView1.EndEdit();
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_item_Click(object sender, EventArgs e)
        {
            frm_item_lookup _item_list = new frm_item_lookup(this);
            _item_list.ShowDialog();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
