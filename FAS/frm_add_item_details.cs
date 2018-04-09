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
    public partial class frm_add_item_details : MetroFramework.Forms.MetroForm
    {
        frm_item_lookup _item_lookup;


        private DataTable _dt;

        SubCategory subCatObj = new SubCategory();
        public frm_add_item_details()
        {
            InitializeComponent();
        }
        private void GetCategory() {
            Category categoryObj = new Category();

            this._dt = new DataTable();

            this._dt = categoryObj.Categories();

            DataRow row = this._dt.NewRow();

            row[0] = 0;
            row[1] = "Select Category";

            this._dt.Rows.InsertAt(row, 0);

            this.cb_category.DisplayMember = this._dt.Columns[1].ToString();
            this.cb_category.ValueMember = this._dt.Columns[0].ToString();
            this.cb_category.DataSource = this._dt;

            this.cb_category.SelectedIndex = 0;
        }
        public frm_add_item_details(frm_item_lookup item_lookup)
        {
            InitializeComponent();
            this._item_lookup = item_lookup;
        }
        private void frm_add_item_details_Load(object sender, EventArgs e)
        {
            this.GetCategory();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try {
                Item itemObj = new Item();

                itemObj.CategoryId = int.Parse(cb_category.SelectedValue.ToString());
                itemObj.SubCategoryId = int.Parse(cb_sub_category.SelectedValue.ToString());
                itemObj.Brand = txt_brand.Text;
                itemObj.Model = txt_model.Text;
                itemObj.HasSerialNumber = metroCheckBox1.Checked;
                if (itemObj.CreateNewItem()) {
                    MessageBox.Show("Saved");
                }
                this._item_lookup.dataGridView1.Refresh();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._dt = new DataTable();
            subCatObj.CategoryId = cb_category.SelectedIndex;
            this._dt = subCatObj.SubCategories();

            DataRow row = this._dt.NewRow();

            row[0] = 0;
            row[2] = "Select Sub Category";

            this._dt.Rows.InsertAt(row, 0);

            this.cb_sub_category.DisplayMember = this._dt.Columns[2].ToString();
            this.cb_sub_category.ValueMember = this._dt.Columns[0].ToString();
            this.cb_sub_category.DataSource = this._dt;

            this.cb_sub_category.SelectedIndex = 0;
        }
    }
}
