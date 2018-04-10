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
    public partial class uc_item_receipt : UserControl
    {
        frm_fas _main;
        Items _items;
        Receipt _receipt;
        List<Serial> _serial_list;
        public uc_item_receipt(frm_fas main,Items items)
        {
            InitializeComponent();
            _main = main;
            _items = items;

            if (items.HasSerial == 0) {
                btn_next.Text = "Save";
            }
        }
        public uc_item_receipt(frm_fas main, Items items,Receipt receipt)
        {
            InitializeComponent();
            _main = main;
            _items = items;
            _receipt = receipt;

            txt_official_receipt.Text = _receipt.OfficialReceipt;

            if (items.HasSerial == 0)
            {
                btn_next.Text = "Save";
            }
        }
        public uc_item_receipt(frm_fas main, Items items, Receipt receipt,List<Serial> serial_list)
        {
            InitializeComponent();
            _main = main;
            _items = items;
            _receipt = receipt;
            _serial_list = serial_list;
            txt_official_receipt.Text = _receipt.OfficialReceipt;

            if (items.HasSerial == 0)
            {
                btn_next.Text = "Save";
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt() {
                ItemId = _items.Id,
                OfficialReceipt = txt_official_receipt.Text,
                Price = 1.00,
                Quantity = 1
            };
            _main.panel_body.Controls.Clear();
            uc_add_item_details _item_details = new uc_add_item_details(_main,_items,receipt);
            _main.panel_body.Controls.Add(_item_details);
            _item_details.Show();
        }
    }
}
