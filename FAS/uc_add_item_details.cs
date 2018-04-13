using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FAS
{
    public partial class uc_add_item_details : UserControl
    {
        frm_fas _main;
        ItemModel _item_model;
        ReceiptModel _receipt_model;
        List<Serial> _serial_list;
        ItemRepository itemRepository = new ItemRepository();

        private int _item_id=0;
        public uc_add_item_details(frm_fas main)
        {
            InitializeComponent();
            _main = main;

            AutoCompleteModel();

            GetCategories();
        }
        public uc_add_item_details(frm_fas main,ItemModel itemModel,ReceiptModel receiptModel)
        {
            InitializeComponent();
            _main = main;
            _item_model = itemModel;
            _receipt_model = receiptModel;

            AutoCompleteModel();

            GetCategories();

            SetItemDetails();
        }
        public uc_add_item_details(frm_fas main, ItemModel itemModel, ReceiptModel receiptModel,List<Serial> serialList)
        {
            InitializeComponent();
            _main = main;
            _item_model = itemModel;
            _receipt_model = receiptModel;
            _serial_list = serialList;

            AutoCompleteModel();

            GetCategories();

            SetItemDetails();
        }
        private void GetCategories() {
            CategoryRepository categoryRepository = new CategoryRepository();
            var list = categoryRepository.CategoryList();
            list.Insert(0, new Category() { CategoryName = "-Select-" });

            var source = new BindingSource();
            source.DataSource = list;

            cb_category.DisplayMember = "CategoryName";
            cb_category.ValueMember = "Id";
            cb_category.DataSource = source;

            cb_category.SelectedIndex = 0;

        }
        private void GetSubCategories() {

            var selected_category = Convert.ToInt32(cb_category.SelectedValue.ToString());
            SubCategoryRepository subCategoryRepository = new SubCategoryRepository();
            var list = subCategoryRepository.SubCategoryList(selected_category);
            list.Insert(0, new SubCategory() { SubCategoryName = "-Select-" });

            var source = new BindingSource();
            source.DataSource = list;

            cb_sub_category.DisplayMember = "SubCategoryName";
            cb_sub_category.ValueMember = "Id";
            cb_sub_category.DataSource = source;

            cb_sub_category.SelectedIndex = 0;
        }
        private void SetItemDetails() {
            Console.WriteLine("Item id is " + _item_model.Id);
            _item_id = _item_model.Id;
            txt_brand.Text = _item_model.Brand;
            txt_model.Text = _item_model.Model;
            cb_category.SelectedValue = _item_model.CategoryId;
            cb_sub_category.SelectedValue = _item_model.SubCategoryId;
            checkbox_has_serial.Checked = _item_model.HasSerial == 1;


        }
        private Items InitializeItem() {
            Items items = new Items();
            
            items.Id = _item_id;
            items.Model = txt_model.Text;
            items.Brand = txt_brand.Text;
            items.CategoryId = Convert.ToInt32(cb_category.SelectedValue.ToString());
            items.SubCategoryId = Convert.ToInt32(cb_sub_category.SelectedValue.ToString());
            items.HasSerial = Convert.ToInt32(checkbox_has_serial.Checked);

            return items;
        }
        private void AutoCompleteModel() {
            txt_model.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_model.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection namec = new AutoCompleteStringCollection();

            ItemRepository itemManager = new ItemRepository();
            var list = itemManager.GetAllItems(txt_model.Text);
            if (list.Count >= 0)
            {
                foreach (var itemlist in list)
                {
                    namec.Add(itemlist.Model);
                }
            }
            txt_model.AutoCompleteCustomSource = namec;
        }
        private void EnableDisableControl(bool hasValue) {
            txt_brand.Enabled = hasValue;
            cb_category.Enabled = hasValue;
            cb_sub_category.Enabled = hasValue;
            checkbox_has_serial.Enabled = hasValue;
        }
        private void uc_add_item_details_Load(object sender, EventArgs e)
        {
            txt_model.Focus();
            if (_item_model != null) {
                SetItemDetails();
            }   
        }

        private void txt_model_TextChanged(object sender, EventArgs e)
        {
            var item = itemRepository.GetItem(txt_model.Text);
            _item_id = item.Id;
            txt_brand.Text = item.Brand;
            cb_category.SelectedValue = Convert.ToInt32(item.CategoryId);
            cb_sub_category.SelectedValue = Convert.ToInt32(item.SubCategoryId);
            checkbox_has_serial.Checked = item.HasSerial == 1;
            
            EnableDisableControl(item.Id == 0);

            //if (item.Id == 0) {
            //    _receipt_model = null;
            //    _serial_list = null;
            //}
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSubCategories();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                var items = InitializeItem();
                _main.panel_body.Controls.Clear();
                uc_item_receipt item_receipt;
                switch (_receipt_model == null)
                {
                    case true:
                        item_receipt = new uc_item_receipt(_main, items);
                        _main.panel_body.Controls.Add(item_receipt);
                        item_receipt.Show();
                        break;
                    case false:
                        switch (_serial_list == null) {
                            case true:
                                item_receipt = new uc_item_receipt(_main, items, _receipt_model);
                                _main.panel_body.Controls.Add(item_receipt);
                                item_receipt.Show();
                                break;
                            case false:
                                item_receipt = new uc_item_receipt(_main, items, _receipt_model,_serial_list);
                                _main.panel_body.Controls.Add(item_receipt);
                                item_receipt.Show();
                                break;
                            default:
                                //
                                break;
                        }
                        break;
                    default:
                        //
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
