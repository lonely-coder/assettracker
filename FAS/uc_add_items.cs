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
    public partial class uc_add_items : UserControl
    {
        public int _existing_item = 0;
        int item_id;
        uc_item_list _item_list;
        frm_fas _main;

        DataTable _categoryDT = new DataTable();
        DataTable _tempItemDT = new DataTable();

        DataGridViewComboBoxColumn cb_items = new DataGridViewComboBoxColumn();
        ComboBox comboBox2 = new ComboBox();
        public uc_add_items()
        {
            InitializeComponent();
         
        }
        public uc_add_items(frm_fas Main)
        {
            InitializeComponent();
            _main = Main;
        }
        public uc_add_items(uc_item_list item_list)
        {
            InitializeComponent();
            this._item_list = item_list;
        }
        public void Items() {
            Item item = new FAS.Item();
            //item.Query = "SELECT * FROM item_list";
            DataTable itemDT = item.SelectTempItems();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = itemDT;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[8].Visible = false;

            DataGridViewButtonColumn btnView = new DataGridViewButtonColumn();
            btnView.HeaderText = "#";
            btnView.Text = "Update";
            btnView.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnView);

            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
            btnRemove.HeaderText = "##";
            btnRemove.Text = "Delete";
            btnRemove.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnRemove);
        }
        public void AddRows() {
            Item item = new Item();

            _tempItemDT = item.SelectTempItems();


            cb_items.DisplayMember = _tempItemDT.Columns[5].ToString();
            cb_items.ValueMember = _tempItemDT.Columns[0].ToString();
            cb_items.DataSource = _tempItemDT;

            DataRow row = _tempItemDT.NewRow();

            row[0] = 0;
            row[5] = "Select Item";

            _tempItemDT.Rows.InsertAt(row, 0);
            
        }
        
        public void Vendors() {
            Vendors vendor = new Vendors();
            DataTable _vendorsDT = vendor.SelectAllVendords();

            DataRow _row = _vendorsDT.NewRow();
            _row[0] = 0;
            _row[1] = "Select Vendors";
            _vendorsDT.Rows.InsertAt(_row, 0);

            metroComboBox1.DisplayMember = _vendorsDT.Columns[1].ToString();
            metroComboBox1.ValueMember = _vendorsDT.Columns[0].ToString();
            metroComboBox1.DataSource = _vendorsDT;
            metroComboBox1.SelectedIndex = 0;
        }
        private void btn_add_item_Click(object sender, EventArgs e)
        {

        }

        private void uc_add_items_Load(object sender, EventArgs e)
        {
            this.Vendors();
            
            DataGridViewButtonColumn btnRemoveSerial = new DataGridViewButtonColumn();
            btnRemoveSerial.HeaderText = "##";
            btnRemoveSerial.Text = "Delete";
            btnRemoveSerial.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(btnRemoveSerial);
            dataGridView2.AutoGenerateColumns = false;
            
            cb_items.HeaderText = "Items";
            cb_items.Selected.Equals(0);

            dataGridView2.Columns.Insert(0, cb_items);
            

        }

        //private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    if (dataGridView1.CurrentCell.ColumnIndex == 0)
        //    {
        //        // Check box column
        //        ComboBox comboBox = e.Control as ComboBox;
        //        comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
        //    }
        //}
        //void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int selectedIndex = ((ComboBox)sender).SelectedIndex;
            
        //}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id= int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                switch (senderGrid.Columns[e.ColumnIndex].HeaderText) {
                    case "#":
                            frm_add_item _update_item = new frm_add_item(this, id);
                            _update_item.ShowDialog();
                        
                        break;
                    case "##":
                        //dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                        //Item item = new Item();
                        //item.Id = id;
                        //item.DeleteTempItemsPerId();
                        //this.Items();
                        break;
                    default:
                        break;
                }
             
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {

            
        }

        //private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
            
            
        //    if (dataGridView2.CurrentCell.ColumnIndex == 0)
        //    {
        //        // Check box column
        //        comboBox2 = e.Control as ComboBox;
                
        //        comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged);
                
        //    }
        //}

        //void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int selectedIndex = ((ComboBox)sender).SelectedIndex;
        //    //MessageBox.Show(selectedIndex.ToString());
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            DataTable _itemDT = item.SelectTempItems();
            int item_count = 0;

            if (dataGridView2.Rows.Count != 0)
            {
                //check comboboxes on datagrid if set to an item id
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()) == 0)
                    {
                        dataGridView2.Rows[i].Selected = true;
                        MessageBox.Show("Please select an Item on the selected row");
                        return;
                    }

                }
                //check if number of serial numbers matched the quantity of items on item grid
                foreach (DataRow itemDr in _itemDT.Rows)
                {
                    foreach (DataGridViewRow serialDgv in dataGridView2.Rows)
                    {
                        
                        if (itemDr[0].ToString() == serialDgv.Cells[0].Value.ToString())
                        {
                            item_count++;
                        }
                    }
                    if (item_count.Equals(int.Parse(itemDr["quantity"].ToString())) ||item_count.Equals(0))
                    {
                        item_count = 0;
                        //return;
                    }
                    else
                    {
                        MessageBox.Show("Please provide the correct quantity of Serial Numbers");
                        return;
                    }
                }
            }
            if(dataGridView1.Rows.Count == 0) {
                MessageBox.Show("No Items has been added");
                return;
            }
            // insert item on database
            try
            {
                
                foreach (DataRow row in _itemDT.Rows) {
                    //MessageBox.Show(row["item_id"].ToString());
                    if (int.Parse(row["item_id"].ToString()) == 0)
                    {

                        item.CategoryId = int.Parse(row["category_id"].ToString());
                        item.SubCategoryId = int.Parse(row["sub_category_id"].ToString());
                        item.Brand = row["brand"].ToString();
                        item.Model = row["model"].ToString();
                        item.Description = row["description"].ToString();
                        item.AddNewItem();
                        item_id = int.Parse(item.LastInsertedId().ToString());
                    }
                    else {

                        item_id = int.Parse(row["item_id"].ToString());
                    }
                    //Add Receipts
                    Receipt receipt = new Receipt();
                    receipt.ItemId = item_id;
                    receipt.VendorId= int.Parse(metroComboBox1.SelectedValue.ToString());
                    receipt.OfficialReceipt = textBox1.Text;
                    receipt.Price = double.Parse(row["price"].ToString());
                    receipt.Quantity = int.Parse(row["quantity"].ToString());
                    DateTime datePurchased = Convert.ToDateTime(dateTimePicker1.Value.Date.ToString());
                    receipt.DatePurchased = datePurchased;
                    DateTime dateWarranty = Convert.ToDateTime(row["warranty"].ToString());
                    receipt.WarrantyDate = dateWarranty;
                    receipt.ItemReceipt();
                    int item_receipt = int.Parse(receipt.LastInsertedId().ToString());
                    //Add Serial Numbers Per Item//
                    foreach (DataGridViewRow rows in dataGridView2.Rows) {
                        if (rows.Cells[0].Value.ToString() == row[0].ToString()) {
                            Serial serial = new Serial();
                            serial.ItemId = item_id;
                            serial.ReceiptId = item_receipt;
                            serial.SerialNumber = rows.Cells[1].Value.ToString();
                            serial.AddSerial();
                        }
                    }

                }
                MessageBox.Show("Item(s) has been saved");
                dataGridView1.DataSource = null;
                dataGridView2.Rows.Clear();
                textBox1.Clear();
                metroComboBox1.SelectedIndex = 0;
                item.DeleteTempItems();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "##")
            {
                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this._item_list.ViewControls();
            _item_list.Items();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_item_list != null)
            {
                this.Visible = false;
                _item_list.ViewControls();
                _item_list.Items();
            }
            else {
                //MessageBox.Show("Test");
                _main.ViewControls();
                _main.panel_body.Controls.Remove(this);
            }
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                this.AddRows();
                dataGridView2.Rows.Add();
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[0].Value = 0;
            }
            else
            {
                MessageBox.Show("You Must Add an Item first");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frm_add_item _add_item = new frm_add_item(this);
            _add_item.ShowDialog();
        }
    }
}
