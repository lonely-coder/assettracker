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
    public partial class uc_item_list : UserControl
    {
        private int _user_id;
        private int _privilege_id;
        private DataTable _dt;

        frm_fas _main;
        

        public uc_item_list()
        {
            InitializeComponent();
        }
        public uc_item_list(frm_fas main,int UserId)
        {
            InitializeComponent();
            this._user_id = UserId;
            this._main = main;

            Users user = new Users();
            user.Id = this._user_id;
            this._privilege_id = user.SelectUser();
        }
        public void Items()
        {
            try {
                ItemRepository itemManager = new ItemRepository();
                var list = itemManager.GetAllItems(metroTextBox1.Text);
                var bindingList = new BindingList<Items>(list);
                var source = new BindingSource(bindingList, null);
                dg_item_grid.Columns.Clear();
                dg_item_grid.DataSource = source;
                dg_item_grid.Columns["ID"].Visible = false;
                dg_item_grid.Columns["CategoryId"].Visible = false;
                dg_item_grid.Columns["SubCategoryId"].Visible = false;
                dg_item_grid.Columns["HasSerial"].Visible = false;
                dg_item_grid.Columns["OnLoan"].Visible = false;
                DataGridViewButtonColumn btn_preview = new DataGridViewButtonColumn();
                btn_preview.HeaderText = "#";
                btn_preview.Text = "Details";
                btn_preview.UseColumnTextForButtonValue = true;
                dg_item_grid.Columns.Add(btn_preview);
                
                
                DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
                btn2.HeaderText = "###";
                btn2.Text = "Inventory";
                btn2.UseColumnTextForButtonValue = true;
                this.dg_item_grid.Columns.Add(btn2);
                
                dg_item_grid.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        public void ViewControls()
        {
            this.dg_item_grid.Visible = true;
            this.metroTextBox1.Visible = true;
            this.btn_search.Visible = true;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dg_item_grid.CurrentRow.Cells["id"].Value.ToString());
            
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                switch (senderGrid.Columns[e.ColumnIndex].HeaderText)
                {
                    case "#":
                        frm_item_detail _detail = new frm_item_detail(this,id,this._user_id);
                        _detail.ShowDialog();
                        break;
                    case "##":
                        //MessageBox.Show("Add Quantity");
                        break;
                    case "###":
                        uc_item_inventory _item_inventory = new uc_item_inventory(this, id,this._user_id);
                        this.Controls.Clear();
                        this.Controls.Add(_item_inventory);
                        
                        break;
                        
                }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Items();
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            uc_add_item _item = new uc_add_item(this._main);
            this._main.panel_body.Controls.Clear();
            this._main.panel_body.Controls.Add(_item);
            _item.Show();
            
        }
    }
}
