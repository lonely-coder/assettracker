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
    public partial class frm_dashboard : Form
    {
        frm_fas _main_form;
        public frm_dashboard()
        {
            InitializeComponent();
        }
        public frm_dashboard(frm_fas main_form)
        {
            InitializeComponent();
            _main_form = main_form;
        }
        private void frm_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_asset_Click(object sender, EventArgs e)
        {
            //uc_add_assets _add_assets = new uc_add_assets(_main_form);
            //_main_form.panel_body.Controls.Clear();
            //_main_form.panel_body.Controls.Add(_add_assets);

            uc_add_employee_asset _add_asset = new uc_add_employee_asset();
            //_add_asset.TopLevel= false;
            _main_form.panel_body.Controls.Clear();
            _main_form.panel_body.Controls.Add(_add_asset);
            _add_asset.Show();
            _main_form.lbl_current_tab.Text = "Add Accountability";
        }

        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            frm_employee_info _add_employee = new frm_employee_info();
            _add_employee.ShowDialog();
        }

        private void btn_add_items_Click(object sender, EventArgs e)
        {
            uc_add_item _add_item = new uc_add_item(_main_form);
            _main_form.panel_body.Controls.Clear();
            _main_form.panel_body.Controls.Add(_add_item);
            _main_form.lbl_current_tab.Text = "Add New Item";
        }

        private void btn_add_vendors_Click(object sender, EventArgs e)
        {
            frm_add_vendors _add_vendors = new frm_add_vendors();
            _add_vendors.ShowDialog();
        }

        private void frm_delete_scrap_Click(object sender, EventArgs e)
        {
            //frm_scrap _scrap = new frm_scrap();
            //_scrap.ShowDialog();
        }

        private void btn_emp_list_Click(object sender, EventArgs e)
        {
            frm_department_picker _pick_department = new frm_department_picker();
            _pick_department.ShowDialog();
        }

        private void btn_vendor_list_Click(object sender, EventArgs e)
        {
            frm_preview_vendors _vendors = new frm_preview_vendors();
            _vendors.ShowDialog();
        }

        private void btn_item_list_Click(object sender, EventArgs e)
        {
            frm_preview_all_items _items = new frm_preview_all_items();
            _items.ShowDialog();
        }

        private void btn_employee_assets_Click(object sender, EventArgs e)
        {
            frm_preview_assets _print_assets = new frm_preview_assets();
            _print_assets.ShowDialog();
        }

        private void btn_assets_per_department_Click(object sender, EventArgs e)
        {
            frmSelectDepartment _department = new frmSelectDepartment();
            _department.ShowDialog();
        }

        private void btn_for_scrapping_Click(object sender, EventArgs e)
        {
            frm_select_dept_scrapt _scrap = new frm_select_dept_scrapt();
            _scrap.ShowDialog();
        }
    }
}
