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
    public partial class frm_serial : Form
    {
        frm_receipt _receipt;

        int _serial_id;
        int _item_id;
        int _receipt_id;
        
        public frm_serial(frm_receipt receipt,int ItemId,int ReceiptId)
        {
            InitializeComponent();
            _receipt = receipt;
            this._item_id = ItemId;
            this._receipt_id = ReceiptId;
        }
        public frm_serial(frm_receipt receipt,int SerialId)
        {
            InitializeComponent();
            this._receipt = receipt;
            this._serial_id = SerialId;
        }
        public void Serial() {
            //Serial serial = new Serial();
            //serial.Id = _serial_id;
            //DataTable dt = serial.SelectSerialFromTempTableById();

            //foreach (DataRow row in dt.Rows) {
            //    _item_id = int.Parse(row["item_id"].ToString());
            //    _receipt_id = int.Parse(row["item_receipt_id"].ToString());
            //    textBox1.Text = row["Serial Number"].ToString();
            //}
        }
        private void frm_serial_Load(object sender, EventArgs e)
        {
            if (_serial_id > 0) {
                this.Serial();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
//            Serial serial = new Serial();
            
//            serial.ItemId = this._item_id;
//            serial.ReceiptId = this._receipt_id;
//            serial.SerialNumber= this.textBox1.Text;
//            switch (_serial_id > 0) {
//                case true:
//                    serial.Id = this._serial_id;
//                    serial.UpdateTempSerialTable();
//                    MessageBox.Show("Serial Updated");
//                    break;
//                default:
//                    serial.InsertIntoTempSerialtable();
//                    MessageBox.Show("Serial Added");
//                    break;
//            }

////            this._receipt.Serials();
            
//            this.Close();
        }
    }
}
