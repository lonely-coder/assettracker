using System;
using System.Data;
using System.Windows.Forms;
using FAS.classes;

namespace FAS
{
    public partial class uc_item_inventory : UserControl
    {
        uc_item_list _item_list;
        Logs log;
        
        int _item_id;
        int _user_id;
        int _privilege_id;

        public uc_item_inventory(uc_item_list item_list, int item_id,int userId)
        {
            InitializeComponent();
            _item_list = item_list;
            this._item_id = item_id;
            this._user_id = userId;

            Users user = new Users();
            user.Id = this._user_id;
            this._privilege_id = user.SelectUser();

        }
        public void GetItemDetail() {
            
            ItemRepository itemRepository = new ItemRepository();
            Items items = itemRepository.GetItemById(_item_id);
            lbl_model.Text = string.Format("{0}/{1}>{2}", items.CategoryId, items.SubCategoryId,items.Model); 
            

        }
        public void DisplayItemInventory()
        {
            ItemInventoryViewer itemInventory = new ItemInventoryViewer();
            try {
                DataTable _dt = itemInventory.GetItemIventoryPerId(_item_id);

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = _dt;
                dataGridView1.Columns["receipt_id"].Visible = false;
                dataGridView1.Columns["vendor_id"].Visible = false;

                /*
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "#";
                btn.Text = "View Transaction";
                btn.UseColumnTextForButtonValue = true;
                
                dataGridView1.Columns.Add(btn);
                */
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void uc_item_inventory_Load(object sender, EventArgs e)
        {
            GetItemDetail();
            DisplayItemInventory();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dataGridView1.CurrentRow.Cells["receipt_id"].Value.ToString());
            //var receipt = dataGridView1.CurrentRow.Cells["Official Receipt"].Value.ToString();
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                frm_receipt _receipt = new frm_receipt(this, id,this._user_id);
                _receipt.ShowDialog();
            }
            }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this._item_list.ViewControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frm_preview_all_items _print = new frm_preview_all_items(this._id);
            frm_item_per_model _print = new frm_item_per_model(this._item_id);
            _print.ShowDialog();
        }
    }
}
