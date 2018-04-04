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
    public partial class frm_vendors : Form
    {
        
        
        private frm_add_asset _addAsset;
        private string _action;
        public frm_vendors() {
            InitializeComponent();

        }
        

        public frm_vendors(frm_add_asset AddAsset)
        {
            InitializeComponent();
            this._addAsset = AddAsset;
            this._action = "FORM";
        }
        public void PopulateVendorsGrid() {
            DB dbConn = new DB();

            dbConn.Query = "SELECT * FROM vendors";

            DataTable vendorsDT = dbConn.Select();

            dg_vendorList.DataSource = vendorsDT;

            dg_vendorList.Columns[0].Visible = false;
            dg_vendorList.Columns[1].HeaderText = "Vendor Name";
            dg_vendorList.Columns[2].HeaderText = "Address";
            dg_vendorList.Columns[3].HeaderText = "Contact Number";
            dg_vendorList.Columns[4].Visible = false;
            dg_vendorList.Columns[5].Visible = false;
            dg_vendorList.Columns[6].Visible = false;
            dg_vendorList.Columns[7].Visible = false;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dg_vendorList.Columns.Add(btn);
            btn.HeaderText = "Action";
            btn.Text = "Select";
            btn.UseColumnTextForButtonValue = true;
            btn.Name = "btn";
            dg_vendorList.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.PopulateVendorsGrid();

        }

        private void dg_vendorList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendorId = int.Parse(dg_vendorList.CurrentRow.Cells["id"].Value.ToString());
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                switch (this._action) {
                    case "MAIN":
                        
                        this.Close();
                        break;
                    default:
                        //this._addAsset._vendor_id = vendorId;
                        //this._addAsset.txt_vendor.Text = dg_vendorList.CurrentRow.Cells["vendor_name"].Value.ToString();
                        this.Close();
                        break;
                }
                

            }
        }

        private void btn_new_vendor_Click(object sender, EventArgs e)
        {
            frm_add_vendors _vendors = new frm_add_vendors(this);
            _vendors.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
