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
    public partial class frm_add_asset : MetroFramework.Forms.MetroForm
    {
        public int _pkItemList;
        public int _itemSerial;
        public int _pkEmployeeId;
        private int _assetID;
        private int _employeeID;
        private int _user_id;
        private int _privilege_id;
        public int _vendor_id;

        public int _item_id;
        public int _serial_id;

        int togMove;
        int MValX;
        int MValY;

        Asset asset = new Asset();
        Logs log = new Logs();
        employee_assets_controller _updateAsset;
        public frm_add_asset()
        {
            InitializeComponent();
        }

        public frm_add_asset(employee_assets_controller UpdateAsset, int EmployeeId)
        {
            InitializeComponent();
            this._updateAsset = UpdateAsset;
            this._employeeID = EmployeeId;
        }
        public frm_add_asset(employee_assets_controller UpdateAsset,int AssetId,int UserId)
        {
            InitializeComponent();
            this._updateAsset = UpdateAsset;
            this._assetID = AssetId;
            //this._employeeID = EmployeeId;
            this._user_id = UserId;

            Users user = new Users();
            user.Id = this._user_id;
            this._privilege_id = user.SelectUser();
        }
        public void Exist(string param)
        {
           
        }
        public void Condition() {

            try
            {
                Condition condition = new Condition();
                DataTable dt = condition.SelectItemCondition();

                metroComboBox1.DisplayMember = dt.Columns[1].ToString();
                metroComboBox1.ValueMember = dt.Columns[0].ToString();
                metroComboBox1.DataSource = dt;

                DataRow row = dt.NewRow();

                row[0] = 0;
                row[1] = "Select Item Condition";

                dt.Rows.InsertAt(row, 0);

                metroComboBox1.SelectedIndex = 0;
            }
            catch (Exception ex) {
                MessageBox.Show("Error loading contents. \n Please Contact Your System Administrator");
     
            }
            
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            if (this._privilege_id > 1) {
                txt_model.Enabled = false;
                txt_description.Enabled = false;
                txt_amount.Enabled = false;
                txt_property_tag.Enabled = false;
                txt_serial.Enabled = false;
                btn_browse_item.Enabled = false;
                btn_browse_serial.Enabled = false;
                btn_save.Enabled = false;
                date_acquired.Enabled = false;
                metroComboBox1.Enabled = false;
            }
            this.Condition();
            if (this._assetID > 0) {
                btn_browse_item.Enabled = false;
                //button3.Enabled = false;
                Asset asset = new Asset();
                asset.Id = this._assetID;
                DataTable assetdt = asset.SelectAssetPerId();

                foreach (DataRow row in assetdt.Rows) {
                    _item_id = int.Parse(row["item_id"].ToString());
                    _serial_id = int.Parse(row["serial_id"].ToString());
                    _employeeID = int.Parse(row["pkEmployeeId"].ToString());
                    txt_property_tag.Text = row["Property Tag"].ToString();
                    txt_model.Text = row["Model"].ToString();
                    txt_serial.Text = row["Serial Number"].ToString();
                    txt_serial.Enabled = false;
                    txt_model.Enabled = false;
                    txt_amount.Text = row["Amount"].ToString();
                    txt_description.Enabled = false;
                    date_acquired.Value = Convert.ToDateTime(row["Date Acquired"].ToString());
                    metroComboBox1.SelectedValue = int.Parse(row["state"].ToString());
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try {

                asset.PropertyTag = txt_property_tag.Text;
                asset.ItemId = this._item_id;
                asset.SerialId = this._serial_id;
                asset.EmployeeId = this._employeeID;
                asset.DateAcquired = this.date_acquired.Value.Date;
                asset.ItemPrice = double.Parse(this.txt_amount.Text);
                asset.ItemCondition = int.Parse(this.metroComboBox1.SelectedValue.ToString());
                switch (this._assetID > 0) {
                    case true:
                        asset.Id = this._assetID;
                        asset.UpdateAsset();
                        MessageBox.Show("Record Updated");
                        break;
                    default:
                        asset.CreateAsset();
                        MessageBox.Show("New Record Saved");
                        break;
                }
                this.txt_amount.Clear();
                this.txt_property_tag.Clear();
                this.txt_model.Clear();
                this.txt_description.Clear();
                this.txt_serial.Clear();
                this._assetID = 0;
                this._serial_id = 0;
                this._item_id = 0;
                this._updateAsset.EmployeeAssets();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_browse_item_for_asset _items = new FAS.frm_browse_item_for_asset(this);
            _items.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this._item_id > 0)
            {
                frm_serial_numbers _serial = new frm_serial_numbers(this, this._item_id);
                _serial.ShowDialog();
            }
            else {
                MessageBox.Show("Select An Item First");
            }
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            togMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (togMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_property_tag_Leave(object sender, EventArgs e)
        {
            try {
                asset.PropertyTag = txt_property_tag.Text;
                switch (asset.Exist())
                {
                    case true:
                        MessageBox.Show("Property Tag Already Exist");
                        txt_property_tag.Clear();
                        break;
                    default:

                        break;
                }
            }
            catch (Exception ex) {
    
            }
            
        }

        private void txt_model_MouseClick(object sender, MouseEventArgs e)
        {
            frm_browse_item_for_asset _items = new FAS.frm_browse_item_for_asset(this);
            _items.ShowDialog();
        }
    }
}
