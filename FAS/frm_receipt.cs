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
    public partial class frm_receipt : MetroFramework.Forms.MetroForm { 
        //class
        Item item = new FAS.Item();
        Serial serial = new Serial();
        Receipt receipt = new Receipt();
        Logs log;
        //obj
        uc_item_inventory _item_inventory;

        //dataTable
        DataTable itemDt = new DataTable();
        DataTable tempSerialDt = new DataTable();
        DataTable serialDt = new DataTable();
        //variables
        int _id;
        int _item_id;
        int _serial_id;

        int _user_id;
        int _privilege_id;

        string _or;
        public frm_receipt()
        {
            InitializeComponent();
        }
        public frm_receipt(uc_item_inventory ItemInventory,int Id, int UserId )
        {
            InitializeComponent();
            _item_inventory = ItemInventory;
            this._id = Id;
            this._user_id = UserId;
            Users user = new Users();

            user.Id = this._user_id;
            this._privilege_id = user.SelectUser();
        }

        public void vendors()
        {
            try {
                Vendors vendor = new Vendors();
                DataTable dt = vendor.SelectAllVendords();

                metroComboBox1.DisplayMember = dt.Columns[1].ToString();
                metroComboBox1.ValueMember = dt.Columns[0].ToString();
                metroComboBox1.DataSource = dt;

                DataRow row = dt.NewRow();

                row[0] = 0;
                row[1] = "Select Vendor";

                dt.Rows.InsertAt(row, 0);
                metroComboBox1.SelectedIndex = 0;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void Receipts() {
            //receipt.Id = this._id;
            //DataTable _dt = receipt.SelectReceiptPerId();

            //foreach (DataRow  rows in _dt.Rows) {
            //    this._item_id = int.Parse(rows["item_id"].ToString());
            //    metroComboBox1.SelectedValue = rows["vendor_id"].ToString();
            //    txt_or.Text = rows["Official Receipt"].ToString();
            //    txt_price.Text= rows["Price"].ToString();
            //    txt_quantity.Text = rows["quantity"].ToString();
            //    metroTextBox1.Text = rows["Serial Number"].ToString();
            //    this._serial_id = int.Parse(rows["serial_id"].ToString());
            //    dateTimePicker1.Value = Convert.ToDateTime(rows["Date Purchased"].ToString());
            //    dateTimePicker2.Value = Convert.ToDateTime(rows["Warranty Date"].ToString()); 
            //    //metroTextBox1.;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this._privilege_id > 1) {
                metroComboBox1.Enabled = false;
                txt_or.Enabled = false;
                txt_price.Enabled = false;
                txt_quantity.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                metroTextBox1.Enabled = false;
                btn_save.Enabled = false;
            }
            this.vendors();
            if (this._id > 0) {
                this.Receipts();
            }
            
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try {
                receipt.Id = this._id;
                receipt.VendorId = int.Parse(metroComboBox1.SelectedValue.ToString());
                receipt.ItemId = this._item_id;
                receipt.OfficialReceipt = txt_or.Text;
                receipt.Price = double.Parse(txt_price.Text);
                receipt.Quantity = int.Parse(txt_quantity.Text);
                Serial serial = new Serial();
                serial.SerialNumber = metroTextBox1.Text;
                switch (_serial_id != 0) {
                    case true:
                        serial.Id = _serial_id;
                        serial.ItemId = _item_id;
                        serial.ReceiptId = _id;
                        serial.UpdateSerial();
                        //receipt.Quantity = 1;
                        break;
                    case false:
                        if (metroTextBox1.Text != "N/A") {
                            serial.ReceiptId = this._id;
                            serial.ItemId = this._item_id;
                            serial.AddSerial();
                        }
                        
                        break;
                    default:
                        MessageBox.Show("No Changes has been made");
                        break;
                    
                }
                receipt.DatePurchased = dateTimePicker1.Value;
                receipt.WarrantyDate = dateTimePicker2.Value;
                receipt.UpdateReceipt();
                MessageBox.Show("Records has been updated");

                this._item_inventory.DisplayItemInventory();
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
    /*        frm_serial _serial = new frm_serial(this,_id,_or)*/;
            //_serial.ShowDialog();   
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            txt_quantity.Enabled = string.IsNullOrWhiteSpace(metroTextBox1.Text);
            txt_quantity.Text = "1";
        }
    }
}
