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
    public partial class frm_item_lookup : MetroFramework.Forms.MetroForm
    {
        private DataTable _dt;
        Item itemObj = new Item();

        frm_add_new_item _add_new_item;
        public frm_item_lookup()
        {
            InitializeComponent();
        }
        public frm_item_lookup(frm_add_new_item add_new_item)
        {
            InitializeComponent();
            this._add_new_item = add_new_item;
        }
        private void SearchItem() {
            try
            {
                itemObj.parameter = metroTextBox1.Text;
                this._dt = itemObj.SelectAllItems();
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = _dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "#";
                btn.Text = "Select";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_add_item_details _add_item_details = new frm_add_item_details(this);
            _add_item_details.ShowDialog();
        }

        private void frm_item_lookup_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SearchItem();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex >=0) {
                frm_set_price_and_quantity _price_quantity = new frm_set_price_and_quantity(_add_new_item,this);
                _price_quantity.ShowDialog();
            }
        }
    }
}
