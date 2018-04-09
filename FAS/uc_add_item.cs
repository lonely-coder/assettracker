using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FAS
{
    public partial class uc_add_item : UserControl
    {
        private int _item_id = 0;

        frm_fas _main;

        public uc_add_item(frm_fas main)
        {
            InitializeComponent();
            _main = main;
        }
        
        private void getVendors() {

            VendorRepository vendorRepository = new VendorRepository();
            var list = vendorRepository.VendorList();
            list.Insert(0, new Vendors() { VendorName = "-Select-" });
            var source = new BindingSource();
            source.DataSource = list;

            cb_vendors.DisplayMember = "VendorName";
            cb_vendors.ValueMember = "Id";
            cb_vendors.DataSource = source;
            cb_vendors.SelectedIndex = 0;
        }
        private void getCategory() {
            CategoryRepository categoryRepository = new CategoryRepository();
            var list = categoryRepository.CategoryList();
            list.Insert(0,new Category() { CategoryName = "-Select-"});
            var source = new BindingSource();
            source.DataSource = list;
            cb_category.DisplayMember = "CategoryName";
            cb_category.ValueMember = "Id";
            cb_category.DataSource = source;

            cb_category.SelectedIndex = 0;
        }
        private void getItem() {
            
            ItemRepository itemRepository= new ItemRepository();
            Items items = itemRepository.GetItem(txt_model.Text);
            _item_id = items.Id;
            txt_brand.Text = items.Brand;
            metroCheckBox1.Checked = (items.HasSerial == 1);
            cb_category.SelectedValue = items.CategoryId;
            cb_sub_category.SelectedValue = items.SubCategoryId;
            
            if (this._item_id == 0)
            {
                txt_model.Focus();
                txt_brand.Clear();
                cb_category.SelectedIndex = 0;
                cb_sub_category.SelectedIndex = 0;
                metroCheckBox1.Checked = false;
            }

            txt_brand.Enabled = _item_id == 0;
            cb_category.Enabled = _item_id == 0;
            cb_sub_category.Enabled = _item_id == 0;
            metroCheckBox1.Enabled = _item_id == 0;
        }
        private void EnableSerialManager() {
            lbl_numbers_of_serial.Visible = metroCheckBox1.Checked.Equals(true) && ((numericUpDown_quantity.Value - dg_serialnumbers.Rows.Count)> 0);
            lbl_numbers_of_serial.Text = string.Format("Please provide {0} serial number(s)", numericUpDown_quantity.Value - dg_serialnumbers.Rows.Count);
            txt_serial.Enabled = metroCheckBox1.Checked.Equals(true) && ((numericUpDown_quantity.Value - dg_serialnumbers.Rows.Count) > 0);
            dg_serialnumbers.Enabled = metroCheckBox1.Checked.Equals(true) && ((numericUpDown_quantity.Value - dg_serialnumbers.Rows.Count) > 0);
            
        }
        private void errorUiHandler(string error)
        {
            string _error = error;
            foreach (Control controls in this.mainpanel.Controls)
            {
                if (controls is Label && controls.Text == error)
                {
                    controls.Visible = true;
                    controls.Focus();
                }
                else if (controls is Label && controls.Text.Contains("-"))
                {
                    controls.Visible = false;
                }
            }
        }
        private void resetControlsAndHideErrors()
        {
            foreach (Control controlError in this.mainpanel.Controls)
            {
                if (controlError is Label && controlError.Text.Contains("-"))
                {
                    controlError.Visible = false;
                }
            }
            txt_model.Clear();
            txt_brand.Clear();
            cb_category.SelectedIndex = 0;
            cb_sub_category.SelectedIndex = 0;
            cb_vendors.SelectedIndex = 0;
            txt_price.Clear();
            txt_official_receipt.Clear();
            dtpicker_dateofpurchase.Refresh();
            dtpicker_warrantyperoiod.Refresh();
            dg_serialnumbers.Rows.Clear();
            metroCheckBox1.Checked = false;
            numericUpDown_quantity.Value = 0;
        }
        private Items InitializeItemDetails() {
            Items items = new Items()
            {
                Id = _item_id,
                Model = txt_model.Text,
                Brand = txt_brand.Text,
                CategoryId = int.Parse(cb_category.SelectedValue.ToString()),
                SubCategoryId = int.Parse(cb_sub_category.SelectedValue.ToString()),
                HasSerial = metroCheckBox1.Checked ? 1 : 0,
                Quantity = int.Parse(numericUpDown_quantity.Value.ToString())
            };
            return items;
        }
        private Receipt InitializeReceiptDetails() {
            Receipt receipt = new Receipt()
            {
                VendorId = int.Parse(cb_vendors.SelectedValue.ToString()),
                OfficialReceipt = txt_official_receipt.Text,
                Quantity = int.Parse(numericUpDown_quantity.Value.ToString()),
                Price = Convert.ToDouble(txt_price.Text.ToString()),
                DatePurchased = dtpicker_dateofpurchase.Value,
                WarrantyDate = dtpicker_warrantyperoiod.Value
            };
            return receipt;
        }
        private List<Serial> InitializeSerialNumbers() {
            List<Serial> serial_list = new List<Serial>();

            if (metroCheckBox1.Checked == true)
            {
                foreach (DataGridViewRow row in dg_serialnumbers.Rows)
                {
                    serial_list.Add(new Serial()
                    {
                        SerialNumber = row.Cells[0].Value.ToString()
                    });
                }

            }
            return serial_list;
        }
        private bool serialExist() {
            bool matched = false;
            foreach (DataGridViewRow rows in dg_serialnumbers.Rows)
            {
                matched = (txt_serial.Text == rows.Cells[0].Value.ToString());
            }
            return matched;
        }

        private void SaveItem() {
            try
            {
                var items = InitializeItemDetails();

                var receipt = InitializeReceiptDetails();

                var serial_list = InitializeSerialNumbers();

                ItemCreator itemCreator = new ItemCreator(items, receipt, serial_list);
                itemCreator.CreateItem();

                MessageBox.Show("Items has been saved.");

                resetControlsAndHideErrors();

            }
            catch (Exception ex)
            {
                //MetroFramework.MetroMessageBox.Show(this,ex.Message);
                errorUiHandler(ex.Message);
            }
        }
        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            getItem();
        }

        private void uc_add_item_Load(object sender, EventArgs e)
        {
            txt_price.Text = "0.00";
            //set auto complete of textbox txt_model
            txt_model.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_model.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection namec = new AutoCompleteStringCollection();

            //Items items = new Items();
            ItemRepository itemManager = new ItemRepository();
            var list = itemManager.GetAllItems(txt_model.Text);
            if (list.Count >= 0)
            {
                foreach (var itemlist in list)
                {
                    namec.Add(itemlist.Model);
                }
            }
            txt_model.AutoCompleteCustomSource = namec;
            //end auto complete
            getVendors();

            getCategory();
        }

        private void bt_add_serial_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_serial.Text))
            {
                if (dg_serialnumbers.Rows.Count > 0)
                {
                    
                    if (!serialExist())
                    {
                        dg_serialnumbers.Rows.Add(txt_serial.Text);
                    }
                    else {
                        MessageBox.Show("Serial number already exist");
                    }
                }
                else {
                    dg_serialnumbers.Rows.Add(txt_serial.Text);
                }
                txt_serial.Clear();
                txt_serial.Focus();
                lbl_numbers_of_serial.Text = string.Format("-Please provide {0} serial number(s)", numericUpDown_quantity.Value - dg_serialnumbers.Rows.Count);
            }
            bt_add_serial.Enabled = (dg_serialnumbers.Rows.Count < numericUpDown_quantity.Value);
            txt_serial.Enabled = (dg_serialnumbers.Rows.Count < numericUpDown_quantity.Value);
            lbl_numbers_of_serial.Visible = (dg_serialnumbers.Rows.Count < numericUpDown_quantity.Value);
        }

        private void dg_serialnumbers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if ((senderGrid.Columns[e.ColumnIndex]) is DataGridViewButtonColumn && e.ColumnIndex >= 0) {
                dg_serialnumbers.Rows.Remove(dg_serialnumbers.CurrentRow);
                lbl_numbers_of_serial.Visible = true;
                lbl_numbers_of_serial.Text = string.Format("-Please provide {0} serial number(s)", numericUpDown_quantity.Value - dg_serialnumbers.Rows.Count);
                bt_add_serial.Enabled = (dg_serialnumbers.Rows.Count < numericUpDown_quantity.Value);
                txt_serial.Enabled = (dg_serialnumbers.Rows.Count < numericUpDown_quantity.Value);
                lbl_numbers_of_serial.Visible = (dg_serialnumbers.Rows.Count < numericUpDown_quantity.Value);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //Connection connection = new Connection();
            if (metroCheckBox1.Checked == true)
            {
                if (numericUpDown_quantity.Value == dg_serialnumbers.RowCount)
                {
                    SaveItem();
                }
                else {
                    MessageBox.Show("Quantity and number of serial numbers provided must be equal.");
                }
            }
            else {
                SaveItem();
            }
            
        }
        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubCategoryRepository subCategoryRepository = new SubCategoryRepository();
            var list = subCategoryRepository.SubCategoryList(Convert.ToInt32(cb_category.SelectedValue.ToString()));
            list.Insert(0, new SubCategory() { SubCategoryName = "-Select-" });
            var source = new BindingSource();
            source.DataSource = list;

            cb_sub_category.ValueMember = "Id";
            cb_sub_category.DisplayMember = "SubCategoryName";
            cb_sub_category.DataSource = source;

            cb_sub_category.SelectedIndex = 0;
        }

        private void txt_price_Leave(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(txt_price.Text, out value))
                txt_price.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value.ToString("N2"));
            else 
                txt_price.Text = string.Empty;
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
        private void numericUpDown_quantity_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_quantity.Value < dg_serialnumbers.RowCount)
            {
                MessageBox.Show("Quantity cannot be less than Serial Numbers provided below.");
                numericUpDown_quantity.Value = dg_serialnumbers.Rows.Count;
            }
            else {
                EnableSerialManager();
            }
            
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            dg_serialnumbers.Rows.Clear();

            EnableSerialManager();
        }

        private void txt_serial_TextChanged(object sender, EventArgs e)
        {
            bt_add_serial.Enabled = (txt_serial.Text.Length > 0);
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            if (txt_price.Text.Length == 0) {
                txt_price.Text = "0.00";
            }
        }

        private void numericUpDown_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_numbers_of_serial.Visible =  (metroCheckBox1.Checked == true);
            numericUpDown_quantity.Focus();
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            resetControlsAndHideErrors();
        }

        private void txt_model_Click(object sender, EventArgs e)
        {

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}