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
    public partial class frm_item_detail : MetroFramework.Forms.MetroForm
    {
        int _id;
        int _user_id;
        int _privilege_id;
        Item item = new Item();
        Logs log;
        Category category = new FAS.Category();
        SubCategory subCategory = new SubCategory();
        Users user = new Users();
        

        DataTable itemDt = new System.Data.DataTable();
        DataTable categoryDt = new DataTable();
        DataTable subCategoryDT = new DataTable();

        uc_item_list _item_list;
        public frm_item_detail(uc_item_list ItemList,int id,int userId)
        {
            InitializeComponent();
            this._id = id;
            this._user_id = userId;
            this._item_list = ItemList;
           
            user.Id = this._user_id;
            this._privilege_id = user.SelectUser();

        }
        public void Item() {
            try {
                item.Id = this._id;
                itemDt = item.SelectItemPerID();

                foreach (DataRow row in itemDt.Rows)
                {
                    metroComboBox1.SelectedValue = row["category_id"].ToString();
                    metroComboBox2.SelectedValue = row["sub_category_id"].ToString();
                    txt_brand.Text = row["Brand"].ToString();
                    txt_model.Text = row["Model"].ToString();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(this,ex.Message);
            }
            
        }
        public void Category() {
            try
            {
                categoryDt = category.Categories();

                metroComboBox1.DisplayMember = categoryDt.Columns[1].ToString();
                metroComboBox1.ValueMember = categoryDt.Columns[0].ToString();
                metroComboBox1.DataSource = categoryDt;

                DataRow row = categoryDt.NewRow();

                row[0] = 0;
                row[1] = "Select Category";
                categoryDt.Rows.InsertAt(row, 0);
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void frm_item_detail_Load(object sender, EventArgs e)
        {
            this.Category();
            this.Item();
            
            if (this._privilege_id > 1) {
                metroComboBox1.Enabled = false;
                metroComboBox2.Enabled = false;
                txt_brand.Enabled = false;
                txt_model.Enabled = false;
                btn_update.Enabled = false;
            }
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                subCategory.CategoryId = int.Parse(metroComboBox1.SelectedValue.ToString());
                subCategoryDT = subCategory.SubCategories();

                metroComboBox2.DisplayMember = subCategoryDT.Columns[2].ToString();
                metroComboBox2.ValueMember = subCategoryDT.Columns[0].ToString();
                metroComboBox2.DataSource = subCategoryDT;

                DataRow row = subCategoryDT.NewRow();
                row[0] = 0;
                row[2] = "Select Sub Category";

                subCategoryDT.Rows.InsertAt(row, 0);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try {
                Items items = new Items() {
                    Id = this._id,
                    CategoryId = int.Parse(metroComboBox1.SelectedValue.ToString()),
                    SubCategoryId = int.Parse(metroComboBox2.SelectedValue.ToString()),
                    Model = txt_model.Text,
                    Brand = txt_brand.Text
                };
                ItemRepository itemRepository = new ItemRepository(items);
                itemRepository.UpdateItem();

                MessageBox.Show("Changes Has Been Saved");
                _item_list.Items();
                this.Close();
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
