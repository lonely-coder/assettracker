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
    public partial class uc_add_item_details : UserControl
    {
        frm_fas _main;
        Items _items;
        Receipt _receipt;
        List<Serial> _serial_list;
        public uc_add_item_details(frm_fas main)
        {
            InitializeComponent();
            _main = main;
        }
        public uc_add_item_details(frm_fas main,Items items,Receipt receipt)
        {
            InitializeComponent();
            _main = main;
            _items = items;
            _receipt = receipt;

            SetItemDetails();
        }
        public uc_add_item_details(frm_fas main, Items items, Receipt receipt,List<Serial> serial_list)
        {
            InitializeComponent();
            _main = main;
            _items = items;
            _receipt = receipt;
            _serial_list = serial_list;

            SetItemDetails();
        }
        private void SetItemDetails() {
            txt_brand.Text = _items.Brand;
            txt_model.Text = _items.Model;
            cb_category.SelectedValue = _items.CategoryId;
            cb_sub_category.SelectedValue = _items.SubCategoryId;
            checkbox_has_serial.Checked = _items.HasSerial == 1;
        }
        private void uc_add_item_details_Load(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Items items = new Items()
            {
                Id = 2,
                Brand = txt_brand.Text,
                Model = txt_model.Text,
                CategoryId = 1,//Convert.ToInt32(cb_category.SelectedValue.ToString()),
                SubCategoryId =2, //Convert.ToInt32(cb_sub_category.SelectedValue.ToString()),
                HasSerial =1// Convert.ToInt32(checkbox_has_serial.Checked.ToString())
            };

            uc_item_receipt item_receipt;
            switch (_receipt == null)
            {
                case true:
                    _main.panel_body.Controls.Clear();
                    item_receipt = new uc_item_receipt(_main, items);
                    _main.panel_body.Controls.Add(item_receipt);
                    item_receipt.Show();
                    break;
                case false:
                    _main.panel_body.Controls.Clear();
                    item_receipt = new uc_item_receipt(_main, _items, _receipt);
                    _main.panel_body.Controls.Add(item_receipt);
                    item_receipt.Show();
                    break;
                default:
                    break;
            }


        }
    }
}
