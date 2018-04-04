using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace FAS
{
    public partial class uc_add_employee_asset : UserControl
    {
        private int _item_id = 0;
        private int _employee_id = 0;
        private int _item_serial = 0;
        private bool _item_has_serial = false;
        private bool _item_is_available = false;
        public uc_add_employee_asset()
        {
            InitializeComponent();
        }
        private void ClearEmpInfoIfEmpIdIsZero() {
            if (_employee_id == 0)
            {
                txt_name.Clear();
                txt_dept.Clear();
                txt_position.Clear();
            }
        }
        private void EnableControrlsForEmployeeInfo()
        {
            lbl_emp_id_not_found.Visible = !(_employee_id > 0);
            txt_name.Enabled = !(_employee_id > 0);
            txt_dept.Enabled = !(_employee_id > 0);
            txt_position.Enabled = !(_employee_id > 0);
        }

        private void SetMatchedEmployeeInformation()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            Employee employee = employeeRepository.SelectByCompanyId(txt_employee_id.Text);
            _employee_id = employee.ID;
            if (_employee_id > 0) {
                txt_name.Text = employee.FirstName + ' ' + employee.LastName;
                txt_dept.Text = employee.Department.DepartmentNames.ToString();
                txt_position.Text = employee.Position.PositionName.ToString();
            }
            ClearEmpInfoIfEmpIdIsZero();

            lbl_emp_id_not_found.Visible = !(_employee_id > 0);
            EnableControrlsForEmployeeInfo();
        }        
        private void SetMatchedItemInformationOn()
        {
            numberic_up_down_quantity.Value = 0;
            ItemRepository itemManager = new ItemRepository();
            Items items = itemManager.GetItem(txt_model.Text);
            if (items.Id > 0)
            {
                _item_id = items.Id;
                _item_has_serial = items.HasSerial == 1;
                _item_is_available = ((items.Quantity - items.OnLoan) < 0);
                lbl_serial_required.Visible = _item_has_serial;
                metroComboBox1.Enabled = _item_has_serial;
                numberic_up_down_quantity.Enabled = !_item_has_serial;
                ItemPriceSuggestion();
                if (_item_has_serial)
                {
                    numberic_up_down_quantity.Value = 1;
                    GetAvailableSerial();
                }
                else {
                    lbl_serial_required.Text = "This item is not serialized";
                    lbl_serial_required.Visible = true;
                }
                

                if (items.Quantity == 0) 
                    lbl_item_not_found.Visible = true;
                    lbl_item_not_found.Text = "Out of stock.";
                
            }
            else {
                numberic_up_down_quantity.Value = 0;
                lbl_serial_not_available.Visible = false;
            }
            
        }
        private void GetAvailableSerial()
        {
            SerialRepository serialRepository = new SerialRepository();
            var list = serialRepository.GetAllSerialNumbersPerItemId(_item_id);
            list.Insert(0,new Serial() { SerialNumber = "-SELECT-"});
            metroComboBox1.DisplayMember = "SerialNumber";
            metroComboBox1.ValueMember = "Id";
            metroComboBox1.DataSource = list;
        }
        private void EmployeeInformationAutoComplete()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            var employee_list = employeeRepository.selectAll(txt_employee_id.Text);
            AutoCompleteStringCollection namec = new AutoCompleteStringCollection();
            
                foreach (var list in employee_list )
                {
                    namec.Add(list.EmployeeID);

                }   
            txt_employee_id.AutoCompleteCustomSource = namec;
        }

        private void ItemInformationAutoComplete() {
            
            txt_model.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_model.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection namec = new AutoCompleteStringCollection();
            ItemRepository itemManager = new ItemRepository();
            var list = itemManager.GetAllItems(txt_model.Text);
            if (list.Count > 0 )
            {
                foreach (var itemlist in list)
                {
                    namec.Add(itemlist.Model);
                }
            }
            txt_model.AutoCompleteCustomSource = namec;
        }
        private void ItemPriceSuggestion()
        {
            ReceiptRepository receiptRepository= new ReceiptRepository();
            var list = receiptRepository.ItemPriceRange(_item_id);
            cb_price_list.ValueMember = "Price";
            cb_price_list.DataSource = list;

        }
        private void ItemPriceForDefinedSerial() {
            ReceiptRepository receiptRepository = new ReceiptRepository();
            var list = receiptRepository.GetPrice(_item_serial);

            cb_price_list.ValueMember = "Price";
            cb_price_list.DataSource = list;
        }
        private AssetsModel InitializeAssetModel() {

            AssetsModel assetsModel = new AssetsModel()
            {
                PropertyTag = txt_property_tag.Text.ToUpper(),
                EmployeeId = _employee_id,
                Items = new Items() {
                    Id = _item_id,
                    HasSerial = Convert.ToInt32(_item_has_serial)
                },
                Serial = new Serial() {
                    Id = _item_serial
                },
                Quantity = int.Parse(numberic_up_down_quantity.Value.ToString()),
                Price = double.Parse(cb_price_list.SelectedValue.ToString()),
                DateAcquired = Convert.ToDateTime(dt_picker_date_acquired.Value)
            };
            return assetsModel;
        }
        private void InsertAsset() {
            var assetsModel = InitializeAssetModel();
            AssetsModelDataValidator assetsModelDataValidator = new AssetsModelDataValidator(assetsModel);
            if (assetsModelDataValidator.AssetsModelDataIsValid()) {
                var assetCreator = new AssetCreator(assetsModel);
                assetCreator.CreateEmployeeAsset();
            }
            
        }
        private void ChangeSerialStatusIfExist() {
            if (_item_has_serial && _item_serial > 0)
            {
                var serialRepository = new SerialRepository();
                serialRepository.ChangeSerialStatus(_item_serial);
            }
        }
        private void UpdateItemQuantity() {
            ItemRepository itemRepository = new ItemRepository();
            itemRepository.UpdateOnLoanQuantity(_item_id,Convert.ToInt32(numberic_up_down_quantity.Value));
        }
        private bool CreateEmployeeAsset() {
            bool success = false;
            Connection connection = new Connection();
            MySqlTransaction transaction = null;
            using (var con = connection.GetConnection())
            {
                try
                {
                    transaction = con.BeginTransaction();

                    InsertAsset();

                    UpdateItemQuantity();

                    ChangeSerialStatusIfExist();       

                    transaction.Commit();

                    MessageBox.Show("Records has been saved.");
                    success =  true;
                }

                catch (Exception ex)
                {
                    transaction.Rollback();
                    errorUiHandler(ex.Message);
                    
                }
            }
            return success;
        }
        private void resetControlsAndHideErrors()
        {
            foreach (Control controlError in this.panel1.Controls)
            {
                if (controlError is Label && controlError.Text.Contains("-"))
                {
                    controlError.Visible = false;
                }
                
            }
            _employee_id = 0;
            _item_id = 0;
            _item_serial = 0;
            _item_has_serial = false;

            txt_employee_id.Clear();
            txt_model.Clear();
            metroComboBox1.DataSource = null;
            txt_property_tag.Clear();
            numberic_up_down_quantity.Value = 0;
            lbl_emp_id_not_found.Visible = false;
            lbl_serial_required.Visible = false;
            txt_employee_id.Focus();
        }
        private void errorUiHandler(string error) {
            string _error = error;
            foreach (Control controls in this.panel1.Controls)
            {
                if (controls is Label && controls.Text == error)
                {
                    controls.Visible = true;
                    controls.Focus();
                }
                else if (controls is Label && controls.Text.Contains("-"))
                {
                    controls.Visible = false;
                }
            }
        }
        private bool PropertyTagIsAvailable() {
            AssetsRepository assetsRepository = new AssetsRepository();
            return assetsRepository.CheckPropertyTagIfAvailable(txt_property_tag.Text);
        }
        private void uc_add_employee_asset_Load(object sender, EventArgs e)
        {
            this.ItemInformationAutoComplete();

            this.EmployeeInformationAutoComplete();

        }
        private void txt_model_TextChanged(object sender, EventArgs e)
        {
            SetMatchedItemInformationOn();
            if (txt_model.Text.Length > 0)
            {
                lbl_item_not_found.Visible = _item_id == 0;
            }
        }

        private void txt_employee_id_TextChanged(object sender, EventArgs e)
        {
            SetMatchedEmployeeInformation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CreateEmployeeAsset()) {
                resetControlsAndHideErrors();
            }
        }

        private void txt_property_tag_TextChanged(object sender, EventArgs e)
        {
            lbl_propert_tag_warning.Visible = PropertyTagIsAvailable();
        }

        private void txt_property_tag_Click(object sender, EventArgs e)
        {
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _item_serial = Convert.ToInt32(metroComboBox1.SelectedValue);
            Console.WriteLine(cb_price_list.SelectedValue);
            ItemPriceForDefinedSerial();
        }
    }
}
