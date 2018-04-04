using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
namespace FAS
{
    public partial class uc_add_item_2 : UserControl
    {
        DataTable _dt_cat = new DataTable();
        DataTable _dt_sub_cat = new DataTable();
        DataTable _dt_vendor = new DataTable();

        Vendors vendors = new Vendors();
        Category category = new Category();
        SubCategory subCategory = new SubCategory();
        Logs log;

        uc_item_list _item_list;
        frm_fas _Main;
        public int _item_id;
        public int _id;
        public uc_add_item_2()
        {
            InitializeComponent();
        }
        public uc_add_item_2(frm_fas main)
        {
            InitializeComponent();
            this._Main = main;
        }
        public uc_add_item_2(uc_item_list ItemList)
        {
            InitializeComponent();
            _item_list = ItemList;
        }
        private bool TextisValid(string text)
        {
            Regex money = new Regex(@"^\$(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$");
            return money.IsMatch(text);
        }
        public void Category()
        {
            try
            {

                _dt_cat = category.Categories();

                cb_cat.DisplayMember = _dt_cat.Columns[1].ToString();
                cb_cat.ValueMember = _dt_cat.Columns[0].ToString();
                cb_cat.DataSource = _dt_cat;

                DataRow row = _dt_cat.NewRow();

                row[0] = 0;
                row[1] = "Select Category";

                _dt_cat.Rows.InsertAt(row, 0);

                cb_cat.SelectedIndex = 0;
            }
            catch (Exception ex) {

            }

        }
        public void Vendors()
        {
               try { 
                _dt_vendor = vendors.SelectAllVendords();
                cb_vendors.DisplayMember = _dt_vendor.Columns[1].ToString();
                cb_vendors.ValueMember = _dt_vendor.Columns[0].ToString();
                cb_vendors.DataSource = _dt_vendor;

                DataRow row = _dt_vendor.NewRow();

                row[0] = 0;
                row[1] = "Select Vendor";

                _dt_vendor.Rows.InsertAt(row, 0);

                cb_vendors.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

            }
        }
        private void uc_add_item_2_Load(object sender, EventArgs e)
        {
            this.Category();
            this.Vendors();
            txt_price.Text = "0.00";
        }

        private void txt_serial_Click(object sender, EventArgs e)
        {

        }

        private void txt_serial_TextChanged(object sender, EventArgs e)
        {
            txt_quantity.Enabled = (string.IsNullOrWhiteSpace(txt_serial.Text));
            txt_quantity.Text = "1";
        }

        private void cb_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                subCategory.CategoryId = int.Parse(cb_cat.SelectedValue.ToString());
                _dt_sub_cat = subCategory.SubCategories();

                cb_sub_cat.DisplayMember = _dt_sub_cat.Columns[2].ToString();
                cb_sub_cat.ValueMember = _dt_sub_cat.Columns[0].ToString();
                cb_sub_cat.DataSource = _dt_sub_cat;

                DataRow row = _dt_sub_cat.NewRow();

                row[0] = 0;
                row[2] = "Select Sub Category";

                _dt_sub_cat.Rows.InsertAt(row, 0);

                cb_sub_cat.SelectedIndex = 0;
            }
            catch (Exception ex) {

            }
}

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this._item_list.ViewControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //create an Instance of Item Class
            Item item = new Item();
            //Save New Item
            try {
                if (_item_id == 0)
                {

                    item.CategoryId = int.Parse(cb_cat.SelectedValue.ToString());
                    item.SubCategoryId = int.Parse(cb_sub_cat.SelectedValue.ToString());
                    item.Brand = txt_brand.Text;
                    item.Model = txt_model.Text;
                    item.CreateNewItem();
                    _id = int.Parse(item.LastInsertedId().ToString());
                    //MessageBox.Show(_id.ToString());

                }
                else {
                    _id = _item_id;
                }
                //Save Receipt
                Receipt receipt = new Receipt();
                receipt.ItemId = this._id;
                receipt.VendorId= int.Parse(cb_vendors.SelectedValue.ToString());
                receipt.OfficialReceipt = txt_or.Text;
                receipt.Price = double.Parse(txt_price.Text);
                receipt.Quantity = int.Parse(txt_quantity.Text);
                //receipt.ItemCondition = int.Parse()
                receipt.DatePurchased = this.dateTimePicker1.Value;
                receipt.WarrantyDate = this.dateTimePicker2.Value;
                receipt.ItemReceipt();
                //receipt.LastInsertedId();
                //Add Serial
                if (!string.IsNullOrWhiteSpace(txt_serial.Text) && txt_quantity.Text.Equals("1")) {
                    Serial serial = new Serial();
                    serial.ItemId = _id;
                  //  serial.ReceiptId = int.Parse(receipt.LastInsertedId().ToString());
                    serial.SerialNumber = txt_serial.Text;
                    serial.AddSerial();
                }
                MessageBox.Show("New Item Saved");
                this.cb_cat.SelectedIndex = 0;
                this.cb_sub_cat.SelectedIndex = 0;
                this.cb_vendors.SelectedIndex = 0;
                this.txt_brand.Clear();
                this.txt_model.Clear();
                this.txt_desc.Clear();
                this.txt_or.Clear();
                this.txt_quantity.Clear();
                this.txt_price.Clear();
                this.txt_serial.Clear();
                this.cb_cat.Enabled = true;
                this.cb_sub_cat.Enabled = true;
                this.txt_brand.Enabled = true;
                this.txt_desc.Enabled = true;
                this.txt_model.Enabled = true;
                this._item_id = 0;
                this._id = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_browse_item_for_asset _item = new frm_browse_item_for_asset(this);
            _item.ShowDialog();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {

            
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txt_price_Click(object sender, EventArgs e)
        {

        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
          
            //   string value = txt_price.Text.Replace(",", "")
            //.Replace("$", "").Replace(".", "").TrimStart('0');
            //   decimal ul;
            //   //Check we are indeed handling a number
            //   if (decimal.TryParse(value, out ul))
            //   {
            //       ul /= 100;
            //       //Unsub the event so we don't enter a loop
            //       txt_price.TextChanged -= txt_price_TextChanged;
            //       //Format the text as currency
            //       txt_price.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C2}", ul);
            //       txt_price.TextChanged += txt_price_TextChanged;
            //       txt_price.Select(txt_price.Text.Length, 0);
            //   }
            //   bool goodToGo = TextisValid(txt_price.Text);
            //   //button1.Enabled = goodToGo;
            //   if (!goodToGo)
            //   {
            //       txt_price.Text = "$0.00";
            //       txt_price.Select(txt_price.Text.Length, 0);
            //   }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.cb_cat.SelectedIndex = 0;
            this.cb_sub_cat.SelectedIndex = 0;
            this.cb_vendors.SelectedIndex = 0;
            this.txt_brand.Clear();
            this.txt_model.Clear();
            this.txt_desc.Clear();
            this.txt_or.Clear();
            this.txt_quantity.Clear();
            this.txt_price.Clear();
            this.txt_serial.Clear();
            this.cb_cat.Enabled = true;
            this.cb_sub_cat.Enabled = true;
            this.txt_brand.Enabled = true;
            this.txt_desc.Enabled = true;
            this.txt_model.Enabled = true;
            this._id = 0;
        }
    }
}
