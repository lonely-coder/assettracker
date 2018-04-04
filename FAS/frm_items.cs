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
    public partial class frm_items :MetroFramework.Forms.MetroForm
    {
        uc_add_assets _add_assets;
        //frm_add_item _add_items;

        Item items = new Item();
        Category category = new Category();
        SubCategory subCategory = new SubCategory();
        Logs log;

        DataTable _subCategorydt = new DataTable();
        DataTable _itemsDt = new DataTable();
        DataTable _dt = new DataTable();
        public frm_items()
        {
            InitializeComponent();
        }

        public frm_items(uc_add_assets AddAsset)
        {
            InitializeComponent();
            _add_assets = AddAsset;
        }
        
        public void Items() {
            try
            {
                //Connection connection = new Connection();
                Items items = new Items();
                ItemRepository itemManager = new ItemRepository(items);
                var list = itemManager.GetAllItems(metroTextBox1.Text);
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = list;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var item_id = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                        if (dataGridView1.CurrentRow.Cells["Availability"].Value.ToString() == "Unavailable")
                        {
                            MessageBox.Show("This Item is not Available");
                        }
                        else {
                            _add_assets._item_id = item_id;
                            _add_assets.txt_model.Text = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
                            this.Close();
                        }

                
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Items();
        }
    }
}
