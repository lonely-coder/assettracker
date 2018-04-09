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
    public partial class frm_serial_numbers : Form
    {
        uc_add_assets _add_asset;
        frm_add_asset _add_asset_to_employee;
        Logs log;
        int _id;
        public frm_serial_numbers(frm_add_asset AddAsset,int Id)
        {
            InitializeComponent();
            _add_asset_to_employee = AddAsset;
            this._id = Id;
        }
        public frm_serial_numbers(uc_add_assets AddAsset,int Id)
        {
            InitializeComponent();
            _add_asset = AddAsset;
            _id = Id;
        }
        public void SerialNumbers() {
            Serial serial = new Serial();
            try
            {
                serial.ItemId = this._id;
                DataTable _items = serial.SelectSerialPerItemId();

                switch (_items.Rows.Count > 0)
                {
                    case true:
                        dataGridView1.Columns.Clear();
                        dataGridView1.DataSource = _items;
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].Visible = false;
                        dataGridView1.Columns[3].Visible = false;
                        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                        btn.HeaderText = "#";
                        btn.Text = "Select";
                        btn.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(btn);
                        break;
                    default:
                        Receipt receipt = new Receipt();
                        receipt.ItemId = this._id;
                        //receipt.Se
                        MessageBox.Show("NO Serial Numbers found!");
                        this.Close();
                        break;
                }
            }
            catch (Exception ex) {

            }

        }

        private void frm_serial_numbers_Load(object sender, EventArgs e)
        {

            this.SerialNumbers();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var serialId = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                switch (_add_asset != null) {
                    case true:
                        this._add_asset._serial_id = serialId;
                        this._add_asset.txt_serial.Text = dataGridView1.CurrentRow.Cells["Serial Number"].Value.ToString();
                        this._add_asset.metroTextBox1.Text = dataGridView1.CurrentRow.Cells["Amount"].Value.ToString();
                        this.Close();
                        break;
                    default:
                        this._add_asset_to_employee._serial_id = serialId;
                        this._add_asset_to_employee.txt_serial.Text = dataGridView1.CurrentRow.Cells["Serial Number"].Value.ToString();
                        this.Close();
                        break;
                }
                
            }
            }
    }
}
