using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FAS
{
    public partial class frm_fas:Form
    {

        //variable for adding assets
        public int _employeeId;
        public int _vendorId;
        int _user_id;
        //string _user_name;
        int _privilege_id;

        int togMove;
        int MValX;
        int MValY;

        
        //classes
        //uc_add_items _add_items;
        uc_add_item_2 _add_item_2;
        uc_employee_with_assets _employee_with_assets;
        employee_list_controller _employee_list;
        uc_item_list _item_list;
        uc_vendor_list _vendor_list;
        uc_add_assets _add_assets;
        public frm_fas(int user_id)
        {
            InitializeComponent();
            this._user_id = user_id;

        }
        public frm_fas()
        {
            InitializeComponent();
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
        private void button10_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_fas_Load(object sender, EventArgs e)
        {

            Users user = new Users();
            user.Id = this._user_id;
            this._privilege_id = user.SelectUser();

            frm_dashboard _dashboard = new frm_dashboard(this);
            _dashboard.TopLevel = false;
            panel_body.Controls.Clear();
            panel_body.Controls.Add(_dashboard);
            _dashboard.Show();

            //frm_add_multiple_item _item = new frm_add_multiple_item();
            //uc_add_item _item = new uc_add_item();
            //_item.TopLevel = false;
            //panel_body.Controls.Clear();
            //panel_body.Controls.Add(_item);
            //_item.Show();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            
            this._employee_list = new employee_list_controller(this._user_id);
            panel_body.Controls.Clear();
            panel_body.Controls.Add(this._employee_list);
            lbl_current_tab.Text = "Employee List";
            
        }
        private void button15_Click(object sender, EventArgs e)
        {
            
            this._item_list = new uc_item_list(this,this._user_id);
            panel_body.Controls.Clear();
            panel_body.Controls.Add(this._item_list);
            lbl_current_tab.Text = "Items";
            
        }
        private void button12_Click(object sender, EventArgs e)
        {
            _employee_with_assets = new uc_employee_with_assets(this, this._user_id);
            panel_body.Controls.Clear();
            panel_body.Controls.Add(this._employee_with_assets);
            lbl_current_tab.Text = "Employee Accountabiliies";
         

            
        }
        private void button14_Click(object sender, EventArgs e)
        {
            
            this._vendor_list = new uc_vendor_list();
            panel_body.Controls.Clear();
            panel_body.Controls.Add(this._vendor_list);
            lbl_current_tab.Text = "Vendors";
            
        }


        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            frm_dashboard _dashboard = new frm_dashboard(this);
            panel_body.Controls.Clear();
            _dashboard.TopLevel = false;
            
            panel_body.Controls.Add(_dashboard);
            _dashboard.Show();
            lbl_current_tab.Text = "Dashboard";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_user_id == 1)
            {
                frm_add_user _add_user = new frm_add_user();
                _add_user.ShowDialog();
            }
            else {
                MessageBox.Show("Insufficient Privilege\nContact System Administrator.");
            }
        }

    }
}
