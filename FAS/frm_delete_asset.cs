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
    public partial class frm_delete_asset : MetroFramework.Forms.MetroForm
    {
        employee_assets_controller _employee_assets;
        DataTable _dt;
        int _asset_id;
        Asset asset = new Asset();
        Logs log;
        public frm_delete_asset(employee_assets_controller EmployeeAsset,int Id)
        {
            InitializeComponent();
            this._employee_assets = EmployeeAsset;
            this._asset_id = Id;
        }
        public void Remarks() {
            Remarks remarks = new FAS.Remarks();
            _dt = new DataTable();
            _dt = remarks.AssetRemarks();

            metroComboBox1.DisplayMember = _dt.Columns[1].ToString();
            metroComboBox1.ValueMember = _dt.Columns[0].ToString();
            metroComboBox1.DataSource = _dt;
            DataRow row = this._dt.NewRow();
            row[0] = 0;
            row[1] = "Select";

            _dt.Rows.InsertAt(row, 0);

            metroComboBox1.SelectedIndex = 0;

        }

        private void frm_delete_asset_Load(object sender, EventArgs e)
        {
            this.Remarks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try {

                asset.Id = this._asset_id;
                asset.Remarks = int.Parse(this.metroComboBox1.SelectedValue.ToString());
                asset.DeleteAsset();
                MessageBox.Show("Asset Has Been Deleted");
                _employee_assets.EmployeeAssets();
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
