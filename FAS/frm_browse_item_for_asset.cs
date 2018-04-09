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
    public partial class frm_browse_item_for_asset :MetroFramework.Forms.MetroForm
    { 
        frm_add_asset _add_assets;
        uc_add_item_2 _add_items;

        Item items = new Item();
        Category category = new Category();
        SubCategory subCategory = new SubCategory();
        Logs log;
        DataTable _subCategorydt = new DataTable();
        DataTable _itemsDt = new DataTable();
        DataTable _dt = new DataTable();
        public frm_browse_item_for_asset()
        {
            InitializeComponent();
        }

        public frm_browse_item_for_asset(frm_add_asset AddAsset)
        {
            InitializeComponent();
            _add_assets = AddAsset;
        }
        public frm_browse_item_for_asset(uc_add_item_2 AddItems) {
            InitializeComponent();
            _add_items = AddItems;
        }
        public void Items()
        {
            try
            {
                items.parameter = metroTextBox1.Text;
                _itemsDt = items.SelectAllItems();
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = _itemsDt;
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
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void frm_browse_item_for_asset_Load(object sender, EventArgs e)
        {
            //this.Items();
            //this.Category();

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var item_id = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                switch(_add_assets != null)
                {
                    case true:
                        if (dataGridView1.CurrentRow.Cells["Availability"].Value.ToString() == "Available")
                        {
                            this._add_assets._item_id = item_id;
                            this._add_assets.txt_model.Text = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
                            this._add_assets.txt_description.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
                            this.Close();
                        }
                        else {
                            MessageBox.Show("This item is not Available");
                        }
                    
                        break;
                    case false:
                            this._add_items.cb_cat.SelectedValue = int.Parse(dataGridView1.CurrentRow.Cells["category_id"].Value.ToString());
                        this._add_items.cb_cat.Enabled = false;
                            this._add_items.cb_sub_cat.SelectedValue = int.Parse(dataGridView1.CurrentRow.Cells["sub_category_id"].Value.ToString());
                        this._add_items.cb_sub_cat.Enabled = false;
                            this._add_items.txt_brand.Text = dataGridView1.CurrentRow.Cells["Brand"].Value.ToString();
                        this._add_items.txt_brand.Enabled = false;
                            this._add_items.txt_model.Text  = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
                        this._add_items.txt_model.Enabled = false;
                            this._add_items.txt_desc.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
                        this._add_items.txt_desc.Enabled = false;
                            this._add_items._item_id = item_id;
                            this.Close();
                        break;
                }
                

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
                this.Items();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
