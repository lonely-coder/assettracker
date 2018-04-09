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
    public partial class frm_set_price_and_quantity : MetroFramework.Forms.MetroForm
    {
        frm_item_lookup _item_lookup;
        frm_add_new_item _new_item;
        public frm_set_price_and_quantity()
        {
            InitializeComponent();
        }
        public frm_set_price_and_quantity(frm_add_new_item new_item,frm_item_lookup item_lookup)
        {
            InitializeComponent();
            _item_lookup = item_lookup;
            _new_item = new_item;
        }
        private void frm_set_price_and_quantity_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(metroTextBox1.Text.ToString());

            int item_id = int.Parse(_item_lookup.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string brand = _item_lookup.dataGridView1.CurrentRow.Cells["Brand"].Value.ToString();
            string model = _item_lookup.dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
            string description = _item_lookup.dataGridView1.CurrentRow.Cells["Description"].Value.ToString();

            float price = float.Parse(metroTextBox2.Text.ToString());

            if (quantity>0 && price > 0) {
             
                this.Close();
                this._item_lookup.Close();
            }
            
            
        }
    }
}
