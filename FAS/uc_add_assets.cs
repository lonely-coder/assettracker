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
    public partial class uc_add_assets : UserControl
    {
        frm_fas _main;
        uc_employee_with_assets _employee_asset_list;
        public int _employee_id;
        public int _item_id;
        public int _serial_id;

        Asset asset = new Asset();
        Logs log = new Logs();
        public uc_add_assets()
        {
            InitializeComponent();
        }
        public uc_add_assets(frm_fas Main)
        {
            InitializeComponent();
            _main = Main;
        }
        public uc_add_assets(uc_employee_with_assets EmployeeWithAssets)
        {
            InitializeComponent();
            _employee_asset_list = EmployeeWithAssets;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void Condition() {
            Condition condition = new Condition();
            try
            {
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

            }
        }
        private void uc_add_assets_Load(object sender, EventArgs e)
        {
            this.Condition();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_serial.Clear();
            this._serial_id = 0;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (this._item_id > 0 ) {
                case true:
                    
                    break;
                default:
                    MessageBox.Show("You Must Select an Item First");
                    break;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                asset.PropertyTag = this.txt_property_tag.Text;
                asset.EmployeeId = this._employee_id;
                asset.ItemId = this._item_id;
                asset.SerialId = this._serial_id;
                asset.DateAcquired = this.dt_date_acquired.Value.Date;
                asset.ItemCondition = int.Parse(this.metroComboBox1.SelectedValue.ToString());
                asset.ItemPrice = double.Parse(metroTextBox1.Text);
                asset.CreateAsset();
                //switch () {
                this._employee_id = 0;
                this._item_id = 0;
                metroComboBox1.SelectedIndex = 0;
                metroTextBox1.Clear();
                txt_emp_id.Clear();
                txt_department.Clear();
                txt_position.Clear();
                txt_name.Clear();
                txt_model.Clear();
                txt_property_tag.Clear();
                txt_serial.Clear();
                MessageBox.Show("Asset Saved");
                //}
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_property_tag_Leave(object sender, EventArgs e)
        {
            //this.Exist(txt_property_tag.Text);
        }

        private void txt_property_tag_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_employee_asset_list != null)
            {
                this.Visible = false;
                this._employee_asset_list.ShowControls();
                this._employee_asset_list.EmployeesWithAssets();
            }
            else {

                _main.panel_body.Controls.Remove(this);
               
                

            }
            
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this._employee_asset_list.ShowControls();
            this._employee_asset_list.EmployeesWithAssets();
            
        }

        private void txt_emp_id_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_model_Click(object sender, EventArgs e)
        {
            txt_serial.Clear();
            this._serial_id = 0;
            
        }

        private void txt_serial_Click(object sender, EventArgs e)
        {
            switch (this._item_id > 0)
            {
                case true:
                    
                    break;
                default:
                    MessageBox.Show("You Must Select an Item First");
                    break;
            }
        }

        private void txt_serial_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Action not Allowed");
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_property_tag_Leave_1(object sender, EventArgs e)
        {
            try
            {
                asset.PropertyTag = txt_property_tag.Text;
                switch (asset.Exist())
                {
                    case true:
                        MessageBox.Show("Property Tag Already Exist");
                        txt_property_tag.Clear();
                        break;
                    case false:
                        break;
                    default:

                        break;
                }
            }
            catch (Exception ex) {


            }
            
        }
    }
}
