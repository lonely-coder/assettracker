using System;
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

            uc_add_employee_asset _add_asset = new uc_add_employee_asset();
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

        private void btn_add_vendors_Click(object sender, EventArgs e)
        {
            frm_add_vendors _add_vendors = new frm_add_vendors();
            _add_vendors.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            uc_add_item_details _add_item = new uc_add_item_details(_main_form);
            _main_form.panel_body.Controls.Clear();
            _main_form.panel_body.Controls.Add(_add_item);
            _main_form.lbl_current_tab.Text = "Add New Item";
        }
    }
}
