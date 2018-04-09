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
        int _item_id;
        int _user_id;
        int _privilege_id;
        
        Users user = new Users();
        
        uc_item_list _item_list;
        public frm_item_detail(uc_item_list ItemList,int item_id,int user_id)
        {
            InitializeComponent();
            this._item_id = item_id;
            this._user_id = user_id;
            this._item_list = ItemList;

            
            user.Id = this._user_id;
            this._privilege_id = user.SelectUser();

        }
        public void Item() {

            ItemRepository itemRepository = new ItemRepository();
            var item = itemRepository.GetItemById(_item_id);

            txt_brand.Text = item.Brand;
            txt_model.Text = item.Model;
            metroComboBox1.SelectedValue = Convert.ToInt32(item.CategoryId);
            metroComboBox2.SelectedValue = Convert.ToInt32(item.SubCategoryId);
        }
        public void Category() {
            CategoryRepository categoryRepository = new CategoryRepository();
            var list = categoryRepository.CategoryList();
            list.Insert(0, new Category() { CategoryName = "-Select-" });
            var source = new BindingSource();
            source.DataSource = list;
            metroComboBox1.DisplayMember = "CategoryName";
            metroComboBox1.ValueMember = "Id";
            metroComboBox1.DataSource = source;

            metroComboBox1.SelectedIndex = 0;
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
            SubCategoryRepository subCategoryRepository = new SubCategoryRepository();
            var list = subCategoryRepository.SubCategoryList(Convert.ToInt32(metroComboBox1.SelectedValue.ToString()));
            list.Insert(0, new SubCategory() { SubCategoryName = "-Select-" });
            var source = new BindingSource();
            source.DataSource = list;

            metroComboBox2.ValueMember = "Id";
            metroComboBox2.DisplayMember = "SubCategoryName";
            metroComboBox2.DataSource = source;

            metroComboBox2.SelectedIndex = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try {
                Items items = new Items() {
                    Id = _item_id,
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
