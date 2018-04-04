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
    public partial class frm_add_item : Form
    {
        uc_item_list _items;
        

        public int _item_id;
        int _row;
        public frm_add_item()
        {
            InitializeComponent();
        }
        public frm_add_item(uc_item_list items)
        {
            InitializeComponent();
            this._items = items;
        }
        //public frm_add_item(uc_add_items add_item) {
        //    InitializeComponent();
        //    this._add_items = add_item;
        //}
        //public frm_add_item(uc_add_items update_item,int row)
        //{
        //    InitializeComponent();
        //    _row = row;

        //    this._add_items = update_item;

        //}
        //public frm_add_item(uc_add_items update_item, int row,int existing_item)
        //{
        //    InitializeComponent();
        //    _row = row;
        //    _item_id = existing_item;
        //    this._add_items = update_item;
        //}

        public void Category() {
            Category category = new Category();
            DataTable categoryDt = category.Categories();

            cb_category.DisplayMember = categoryDt.Columns[1].ToString();
            cb_category.ValueMember = categoryDt.Columns[0].ToString();
            cb_category.DataSource = categoryDt;

            DataRow rowCategory = categoryDt.NewRow();
            rowCategory[0] = 0;
            rowCategory[1] = "Select Category";

            categoryDt.Rows.InsertAt(rowCategory, 0);
            cb_category.SelectedIndex = 0;
        }
        public void SubCategory(int Param) {
            SubCategory subCategory = new SubCategory();
            subCategory.CategoryId = Param;
            DataTable subcategoryDT = subCategory.SubCategories();

            cb_sub_category.DisplayMember = subcategoryDT.Columns[2].ToString();
            cb_sub_category.ValueMember = subcategoryDT.Columns[0].ToString();
            cb_sub_category.DataSource = subcategoryDT;

            DataRow rowSubCategory = subcategoryDT.NewRow();
            rowSubCategory[0] = 0;
            rowSubCategory[2] = "Select Sub Category";

            subcategoryDT.Rows.InsertAt(rowSubCategory, 0);
            cb_sub_category.SelectedIndex = 0;
        }
        public void ExistingItem() {
            Item item = new Item();
            
            item.Id = this._item_id;
            DataTable itemDt = item.SelectItemPerID();

            foreach (DataRow row in itemDt.Rows) {
                cb_category.SelectedValue = row["category_id"].ToString();
                cb_sub_category.SelectedValue = row["sub_category_id"].ToString();
                txt_brand.Text = row["Brand"].ToString();
                txt_model.Text = row["Model"].ToString();
                txt_description.Text = row["Description"].ToString();
                
            }

        }

        private void frm_add_item_Load(object sender, EventArgs e)
        {
            
            this.Category();
            
            if (_row > 0)
            {
                
                Item item = new Item();
                item.Id = _row;
                DataTable dt = item.SelectTempItemsPerId();

                foreach (DataRow rows in dt.Rows) {
                    _item_id = int.Parse(rows["item_id"].ToString());
                    cb_category.SelectedValue = rows["category_id"].ToString();
                    cb_sub_category.SelectedValue = rows["sub_category_id"].ToString();
                    txt_brand.Text = rows["brand"].ToString();
                    txt_model.Text = rows["model"].ToString();
                    txt_description.Text = rows["description"].ToString();
                    txt_price.Text = rows["price"].ToString();
                    txt_quantity.Text = rows["quantity"].ToString();
                    DateTime warranty = Convert.ToDateTime(rows["warranty"].ToString());
                    dt_warranty.Value = warranty;
                }
            }
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SubCategory(int.Parse(cb_category.SelectedValue.ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataGridViewButtonColumn btnView = new DataGridViewButtonColumn();
            btnView.HeaderText = "View";
            btnView.Text = "View";
            btnView.UseColumnTextForButtonValue = true;
            Item item = new Item();
            try
            {
                item.CategoryId = int.Parse(cb_category.SelectedValue.ToString());
                item.SubCategoryId = int.Parse(cb_sub_category.SelectedValue.ToString());
                item.Brand = txt_brand.Text;
                item.Model = txt_model.Text;
                item.Description = txt_description.Text;
                item.Price = txt_price.Text;
                item.Quantity = int.Parse(txt_quantity.Text);
                item.WarrantyDate = dt_warranty.Value.Date;
                item.TempId = this._item_id;
                switch (this._row > 0)
                {
                    case true:
                        item.Id = _row;
                        item.UpdateTempItem();
                        //_add_items.AddRows();
                        break;
                    default:
                        item.InsertItemOnTempTable();
                        //_add_items._existing_item = this._item_id;
                        break;

                }
                _item_id = 0;
                cb_category.SelectedIndex = 0;
                cb_sub_category.SelectedIndex = 0;
                txt_brand.Clear();
                txt_model.Clear();
                txt_description.Clear();
                txt_price.Clear();
                txt_quantity.Clear();
                _add_items.Items();
                MessageBox.Show("Item Added");

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_items _items = new frm_items(this);
            _items.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
