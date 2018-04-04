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
    public partial class frm_employees :MetroFramework.Forms.MetroForm{ 

        public int _employee_id;
        int _asset_id;
        
        frm_fas _frm_fas;
        uc_add_assets _add_asset;
        employee_assets_controller _transfer_assets;

        //classes
        Employees employee = new Employees();
        Departments department = new FAS.Departments();
        Position position = new Position();
        Asset asset = new Asset();
        Logs log;
        //datatables
        DataTable employeeDT = new DataTable();
        DataTable departmentDT = new DataTable();
        DataTable positionDT = new DataTable();



        public frm_employees(uc_add_assets AddAsset)
        {
            InitializeComponent();
            _add_asset = AddAsset;
            
        }
        public frm_employees(employee_assets_controller TransferAsset,int employeeId)
        {
            InitializeComponent();
            _transfer_assets = TransferAsset;
            _employee_id = employeeId;

        }
        public frm_employees(employee_assets_controller TransferAsset, int employeeId, int assetId)
        {
            InitializeComponent();
            _transfer_assets = TransferAsset;
            _employee_id = employeeId;
            _asset_id = assetId;
        }
        public void Employees() {
            try {
                employee.parameter = metroTextBox1.Text;
                employeeDT = employee.SelectAllEmployees();
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = employeeDT;
                dataGridView1.Columns["pkEmpId"].Visible = false;
                dataGridView1.Columns["Position"].Visible = false;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "#";
                btn.Text = "Select";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                dataGridView1.ClearSelection();
            }
            catch (Exception ex) {

            }
            
        }

        private void frm_employees_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var empId = int.Parse(dataGridView1.CurrentRow.Cells["pkEmpId"].Value.ToString());
            var senderGrid = (DataGridView)sender;
            
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                switch (this._employee_id > 0) {
                    case true:
                        switch (this._asset_id > 0) {
                            case true:
                                try {
                                    asset.Id = this._asset_id;
                                    asset.EmployeeId = empId;
                                    asset.TransferSelectedAsset();
                                    _transfer_assets.EmployeeAssets();
                                    MessageBox.Show("Asset Transfered");
                                }
                                catch (Exception ex) {
                                    MessageBox.Show(ex.Message);
                                }
                                
                                this.Close();
                                break;
                            case false:
                                DialogResult result = MessageBox.Show("Transfer All Assets?", "Confirmation", MessageBoxButtons.YesNo);
                                switch (result)
                                {
                                    case DialogResult.Yes:
                                        //Asset asset = new Asset();
                                        try {
                                            asset.EmployeeId = this._employee_id;
                                            asset.TransferTo = empId;
                                            asset.TransferAssets();
                                            MessageBox.Show("Successfully Transfered");
                                        }
                                        catch (Exception ex) {
                                            log = new Logs();
                                            log.UserFriendlyError();
                                            
                                        }
                                        
                                        _transfer_assets._employeeId = empId;
                                        _transfer_assets.EmployeeAssets();
                                        this.Close();
                                        //asset.
                                        break;
                                    default:
                                        MessageBox.Show("No Changes Has been Made");
                                        break;
                                }
                                break;

                        }

                        break;
                    default:
                        _add_asset._employee_id = empId;
                        _add_asset.txt_emp_id.Text = dataGridView1.CurrentRow.Cells["Employee ID"].Value.ToString();
                        _add_asset.txt_name.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                        _add_asset.txt_department.Text = dataGridView1.CurrentRow.Cells["Department"].Value.ToString();
                        _add_asset.txt_position.Text = dataGridView1.CurrentRow.Cells["Position"].Value.ToString();
                        this.Close();
                        break;
                }
                
            }
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

                this.Employees();

        }
    }
}
