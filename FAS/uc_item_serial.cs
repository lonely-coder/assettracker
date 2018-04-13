using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FAS
{
    public partial class uc_item_serial : UserControl
    {

        frm_fas _main;
        Items _items;
        ItemModel _item_model;
        ReceiptModel _receipt_model;
        Receipt _receipt;
        List<Serial> _serial_list ;
        BindingSource source = new BindingSource();
        public uc_item_serial(frm_fas main,Items items,Receipt receipt)
        {
            InitializeComponent();
            _main = main;
            _items = items;
            _receipt = receipt;

            initializeReceiptModel();

            _serial_list = new List<Serial>();
        }
        public uc_item_serial(frm_fas main, Items items, Receipt receipt,List<Serial> serialList)
        {
            InitializeComponent();
            _main = main;
            _items= items;
            _receipt = receipt;
            _serial_list = serialList;

            initializeReceiptModel();

            initializeDataGrid();
        }
        private void initializeDataGrid() {
            source.DataSource = _serial_list;
            dg_serialnumbers.Columns.Clear();
            dg_serialnumbers.DataSource = null;
            dg_serialnumbers.DataSource = source;
            dg_serialnumbers.Columns["Id"].Visible = false;
            dg_serialnumbers.Columns["ItemId"].Visible = false;
            dg_serialnumbers.Columns["ReceiptId"].Visible = false;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.Text = "Remove";
            btn.HeaderText = "Action";
            dg_serialnumbers.Columns.Add(btn);

            bt_add_serial.Enabled = (dg_serialnumbers.Rows.Count != _receipt_model.Quantity);
        }
        private void initializeReceiptModel() {
            _receipt_model = new ReceiptModel()
            {
                ItemId = _receipt.ItemId,
                VendorId = _receipt.VendorId,
                OfficialReceipt = _receipt.OfficialReceipt,
                Price = _receipt.Price,
                Quantity = _receipt.Quantity
            };
        }
        private Items items() {
            Items items = new Items()
            {
                Id = _items.Id,
                Brand = _items.Brand,
                Model = _items.Model,
                CategoryId = _items.CategoryId,
                SubCategoryId = _items.SubCategoryId,
                HasSerial = _items.HasSerial,
                Quantity = _receipt.Quantity
            };
            return items;
        }
        private Receipt receipt() {
            return _receipt;
        }
        private void Save() {
            var myItem = items();
            var myReceipt = receipt();

            try
            {
                ItemCreator itemCreator = new ItemCreator(myItem, myReceipt,_serial_list);
                itemCreator.CreateItem();
                MessageBox.Show("Saved.");

                _main.panel_body.Controls.Clear();
                uc_add_item_details _item_details = new uc_add_item_details(_main);
                _main.panel_body.Controls.Add(_item_details);
                _item_details.Show();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            var myItems = items();
            _main.panel_body.Controls.Clear();
            uc_item_receipt _item_receipt = new uc_item_receipt(_main, myItems, _receipt_model, _serial_list);
            _main.panel_body.Controls.Add(_item_receipt);
            _item_receipt.Show();
        }

        private void bt_add_serial_Click(object sender, EventArgs e)
        {
            
            if (txt_serial.Text.Length != 0)
            {
                int counter = 0;
                foreach (var list in _serial_list)
                {
                    if (txt_serial.Text == list.SerialNumber)
                    {
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    _serial_list.Add(new Serial()
                    {
                        SerialNumber = txt_serial.Text
                    });

                    initializeDataGrid();
                }
                else {
                    MessageBox.Show("This serial already exist!");
                    txt_serial.Focus();
                }
            }
            else {
                MessageBox.Show("Cannot add blank serial.");
            }
            bt_add_serial.Enabled = (source.Count != _receipt_model.Quantity);
        }
        private void uc_item_serial_Load(object sender, EventArgs e)
        {
            txt_serial.Focus();
            lbl_serial.Text = string.Format("Please provide {0} Serial Number",_receipt.Quantity);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Save();

            

        }

        private void dg_serialnumbers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_serialnumbers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                source.RemoveAt(dg_serialnumbers.SelectedRows[0].Index);
                initializeDataGrid();
            }
         
        }
    }
}
