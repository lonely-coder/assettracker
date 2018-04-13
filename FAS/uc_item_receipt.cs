using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FAS
{
    public partial class uc_item_receipt : UserControl
    {
        frm_fas _main;
        Items _items;
        ItemModel _item_model;
        ReceiptModel _receipt_model;
        List<Serial> _serial_list;
        uc_item_serial _item_serial;
        private int _item_id=0;

        //Begin Constructors
        public uc_item_receipt(frm_fas main,Items items)
        {
            InitializeComponent();

            txt_price.Text = "0.00";

            InitializeVendorList();

            _main = main;
            _items = items;
            _item_id = _items.Id;

            InitializeItemModel();

            if (_items.HasSerial == 0) {
                btn_next.Text = "Save";
            }
        }
        public uc_item_receipt(frm_fas main, Items items,ReceiptModel receiptModel)
        {
            Console.WriteLine("No Serial Set");
            InitializeComponent();

            txt_price.Text = "0.00";

            InitializeVendorList();

            _main = main;
            _items = items;
            _receipt_model = receiptModel;

            InitializeItemModel();

            InitializeReceiptDetails();

            if (_items.HasSerial == 0)
            {
                btn_next.Text = "Save";
            }
        }
        public uc_item_receipt(frm_fas main, Items items, ReceiptModel receiptModel,List<Serial> serial_list)
        {
            InitializeComponent();

            txt_price.Text = "0.00";

            InitializeVendorList();

            _main = main;
            _items = items;
            _receipt_model = receiptModel;
            _serial_list = serial_list;

            InitializeItemModel();

            InitializeReceiptDetails();
            
            if (_item_model.HasSerial == 0)
            {
                btn_next.Text = "Save";
            }

        }
        //End of Constructors
        private void InitializeItemModel() {
            _item_model = new ItemModel()
            {
                Id = _items.Id,
                Model = _items.Model,
                Brand = _items.Brand,
                CategoryId = _items.CategoryId,
                SubCategoryId = _items.SubCategoryId,
                HasSerial = _items.HasSerial
            };
            Console.WriteLine(_item_model.Id);
        }
        private ReceiptModel InitializeReceipt() {
            /*
            *We will pass this everytime
            *the user clicks the Back button
            */
            _receipt_model = new ReceiptModel()
            {
                ItemId = _item_id,
                VendorId = Convert.ToInt32(cb_vendors.SelectedValue.ToString()),
                OfficialReceipt = txt_official_receipt.Text,
                Price = Convert.ToDecimal(txt_price.Text.ToString()),
                Quantity = Convert.ToInt32(numericUpDown_quantity.Value)
            };
            return _receipt_model;
        }
        
        private void InitializeReceiptDetails() {
            cb_vendors.SelectedValue = _receipt_model.VendorId;
            txt_official_receipt.Text = _receipt_model.OfficialReceipt;
            txt_price.Text = _receipt_model.Price.ToString();
            numericUpDown_quantity.Value = _receipt_model.Quantity;
        }
        private void InitializeVendorList() {

            /*
            *Get All Vendors in Database and 
            *show in combo box
            */
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
        private Items item()
        {
            Items items = new Items()
            {
                Id = _item_model.Id,
                Model = _item_model.Model,
                Brand = _item_model.Brand,
                CategoryId = _item_model.CategoryId,
                SubCategoryId = _item_model.SubCategoryId,
                HasSerial = _item_model.HasSerial,
                Quantity = Convert.ToInt32(numericUpDown_quantity.Value)

            };
            return items;
        }
        private Receipt initializeReceipt() {
            Receipt receipt = new Receipt()
            {
                ItemId = _item_model.Id,
                VendorId = Convert.ToInt32(cb_vendors.SelectedValue.ToString()),
                OfficialReceipt = txt_official_receipt.Text,
                Price = Convert.ToDecimal(txt_price.Text),
                Quantity = Convert.ToInt32(numericUpDown_quantity.Value)
            };
            return receipt;
        }
        private void SaveDataOrShowNextPage() {
            var myItem = item();
            var myReceipt = initializeReceipt();

            switch (_item_model.HasSerial == 1)
            {
                case true:
                    switch (_serial_list == null) {
                        case true:
                            _item_serial = new uc_item_serial(_main, myItem, myReceipt);
                            _main.panel_body.Controls.Add(_item_serial);
                            _item_serial.Show();
                            break;
                        case false:
                            Console.WriteLine("Has val");
                            _item_serial = new uc_item_serial(_main, myItem, myReceipt,_serial_list);
                            _main.panel_body.Controls.Add(_item_serial);
                            _item_serial.Show();
                            break;
                        default:
                            //
                            break;
                    }
                    break;
                case false:
                    Save();
                    break;
            }
        }
        private void Save() {
            var myItem = item();
            var myReceipt= initializeReceipt();
            try
            {
                ItemCreator itemCreator = new ItemCreator(myItem, myReceipt);
                itemCreator.CreateItem();
                MessageBox.Show("Saved!");
                _main.panel_body.Controls.Clear();
                uc_add_item_details _item_details = new uc_add_item_details(_main);
                _main.panel_body.Controls.Add(_item_details);
                _item_details.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            try
            {
                var receiptModel = InitializeReceipt();

                _main.panel_body.Controls.Clear();

                uc_add_item_details _item_details;

                switch (_serial_list == null) {
                    case true:
                        
                        _item_details = new uc_add_item_details(_main, _item_model, receiptModel);
                        _main.panel_body.Controls.Add(_item_details);
                        _item_details.Show();
                        break;
                    case false:
                        Console.WriteLine("has val");
                        _item_details = new uc_add_item_details(_main, _item_model, receiptModel,_serial_list);
                        _main.panel_body.Controls.Add(_item_details);
                        _item_details.Show();
                        break;
                    default:
                        break;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                var myItem = item();
                var myReceipt = initializeReceipt();
                _main.panel_body.Controls.Clear();

                SaveDataOrShowNextPage();
                //switch (_serial_list == null) {
                //    case true:
                //        SaveDataOrShowNextPage();
                //        break;
                //    case false:
                //        Console.WriteLine("Has Serial");
                //        _item_serial = new uc_item_serial(_main, myItem, myReceipt,_serial_list);
                //        _main.panel_body.Controls.Add(_item_serial);
                //        _item_serial.Show();
                //        break;
                //}       
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void uc_item_receipt_Load(object sender, EventArgs e)
        {
            cb_vendors.Focus();
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            if (txt_price.Text == "0" || txt_price.Text.Length == 0) {
                txt_price.Text = "0.00";
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_price_Leave(object sender, EventArgs e)
        {
            decimal value;
            if (decimal.TryParse(txt_price.Text, out value))
                txt_price.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value.ToString("N2"));
            else
                txt_price.Text = string.Empty;
        }
    }
}
